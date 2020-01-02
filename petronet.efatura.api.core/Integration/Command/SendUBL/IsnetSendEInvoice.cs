using System;
using System.ServiceModel;
using System.Threading.Tasks;
using IsNet.EFatura;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class IsnetSendEInvoice : ICommandSendUBL {

        private Task<ServiceResponse> _result;
        private InvoiceServiceClient _serviceProxy;

        public InvoiceType Invoice { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public Task<ServiceResponse> Result { get; set; }

        public IsnetSendEInvoice(
            InvoiceType invoiceType = null) {
            this.Invoice = invoiceType;
        }


        public async Task Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }


            _serviceProxy = IsNetHelper.CreateServiceProxy(
                ServiceInfo.ServiceUrl, 
                ServiceInfo.UserName, 
                ServiceInfo.Password);

            var request = new SendInvoiceXmlRequest()
            {
                Invoices = new[]
                {
                    new InvoiceXml()
                    {
                        InvoiceContent = Serialization.SerializeToBytes(this.Invoice),
                        ReceiverTag = this.ServiceInfo.ReceiverPostboxName
                    }
                }
            };

            await _serviceProxy.SendInvoiceXmlAsync(request)
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

                    this.Result =Task.FromResult(result);
                });
        }

        public void Dispose() {
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
