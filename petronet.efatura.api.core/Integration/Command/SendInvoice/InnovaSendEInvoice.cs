using System;
using System.IO;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using DijitalPlanet.EFaturaEArsiv;
using InnovaEFaturaServis;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.Model;
using petronet.efatura.api.core.ViewModel;

using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command.SendInvoice {
    public class InnovaSendEInvoice<TService> : ICommandSendEInvoice {

        private TService _serviceProxy;
        private Task<ServiceResponse> _result;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }
        public ServiceInfo ServiceInfo { get; set; }

        public InnovaSendEInvoice(TService serviceProxy, 
            InvoiceType invoiceType = null, 
            IMapper mapper = null) {
            this.IMapper = mapper;
            this._serviceProxy = serviceProxy;
            this.Invoice = invoiceType;
        }

        public Task<ServiceResponse> TaskResult() => this._result;
        
        public async Task Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }


            var serviceProxy = (_serviceProxy as IClientInterfaceService);

            SendInvoicesRawRequest request=new SendInvoicesRawRequest()
            {
                Invoices = new[]
                {
                    new OutgoingInvoiceRaw()
                    {
                        Header = new OutgoingInvoiceHeader()
                        {
                            ReceiverAlias = this.ServiceInfo.ReceiverPostboxName,
                            SenderAlias = this.ServiceInfo.ReceiverPostboxName
                        }
                    }
                }
            };
            
            await serviceProxy.SendInvoicesRawAsync(request)
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
