using System;
using System.IO;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using DijitalPlanet.EFaturaEArsiv;
using petronet.efatura.api.core.Model;
using petronet.efatura.api.core.ViewModel;
using uyumsoft;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class DijitalPlanetSendEInvoice<TService> : ICommandSendEInvoice {

        private TService _serviceProxy;
        private Task<ServiceResponse> _result;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }
        public ServiceInfo ServiceInfo { get; set; }

        public DijitalPlanetSendEInvoice(TService serviceProxy, 
            InvoiceType invoiceType = null, 
            IMapper mapper = null) {
            this.IMapper = mapper;
            this._serviceProxy = serviceProxy;
            this.Invoice = invoiceType;
        }

        public Task<ServiceResponse> TaskResult() => this._result;

        string HashXml(string xml) {
            MD5 md5Hash = new MD5CryptoServiceProvider();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(xml));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        byte[] SerializeToBytes() {
            using (MemoryStream ms = new MemoryStream()) {
                var serializer = new XmlSerializer(Invoice.GetType());
                serializer.Serialize(ms, Invoice);
                return ms.ToArray();
            }
        }

        public void Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }


            var serviceProxy = (_serviceProxy as IntegrationServiceSoap);

            serviceProxy.GetFormsAuthenticationTicketAsync(
                    this.ServiceInfo.CorporateCode,
                    this.ServiceInfo.UserName,
                    this.ServiceInfo.Password)
                .ContinueWith(d =>
                {
                    if (!d.IsCompletedSuccessfully) throw new Exception("Ticket bilgisi alınırken istisna oldu!");

                    var request = new SendUBLInvoiceRequest()
                    {
                        Ticket = d.Result,
                        CorporateCode = "",
                        InvoiceRawData = SerializeToBytes(),
                        MapCode = "",
                        ReceiverPostboxName = this.ServiceInfo.ReceiverPostboxName
                    };

                    return serviceProxy?.SendUBLInvoiceAsync(request);
                })
                .ContinueWith(d =>
                {
                    var result = new ServiceResponse()
                    {
                        Hatali = false,
                    };

                    if (d.IsCanceled || d.IsFaulted)
                    {
                        result.Hatali = true;
                        foreach (System.Exception innerException in d.Exception.Flatten().InnerExceptions)
                        {
                            result.Istisna += innerException.ToString();
                        }
                    }
                    else
                    {
                        result.Sonuc = d.IsCompletedSuccessfully ? "İşlem başarıyla tamamlandı" : "İşlem tamamlandı!";
                        result.Data = new {d.Result};
                    }

                    return result;
                });

        }

        public void Dispose() {
            _result?.Dispose();
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
