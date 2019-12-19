using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using EFinans.EFatura;
using petronet.efatura.api.core.Model;
using uyumsoft;
using Exception = System.Exception;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class EFinansSendEInvoice<TService> : ICommandSendEInvoice {

        private Task<ServiceResponse> _result;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }
        private TService _serviceProxy;

        public EFinansSendEInvoice(TService serviceProxy, InvoiceType invoiceType = null, IMapper mapper = null) {

            this.IMapper = mapper;
            this.Invoice = invoiceType;
            this._serviceProxy = serviceProxy;
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

            byte[] barrInvoice = SerializeToBytes();

            var request = new belgeGonderRequest() {
                belgeNo = Invoice.ID.Value,
                belgeTuru = "FATURA_UBL",
                belgeVersiyon = "1.2",
                vergiTcKimlikNo = Invoice.AccountingSupplierParty.Party.PartyIdentification[0].ID.Value,
                mimeType = "application/xml",
                veri = barrInvoice,
                belgeHash = HashXml(Encoding.UTF8.GetString(barrInvoice))
            };
            

            _result = (this._serviceProxy as ConnectorService)?.belgeGonderAsync(request)
                .ContinueWith(d => {
                    var result = new ServiceResponse() {
                        Hatali = false,
                    };

                    if (d.IsCanceled || d.IsFaulted) {
                        result.Hatali = true;
                        foreach (System.Exception innerException in d.Exception.Flatten().InnerExceptions) {
                            result.Istisna += innerException.ToString();
                        }
                    } else {
                        result.Sonuc = d.IsCompletedSuccessfully ? "İşlem başarıyla tamamlandı" : "İşlem tamamlandı!";
                        result.Data = new { d.Result };
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
