using System;
using System.ServiceModel;
using System.Threading.Tasks;
using InnovaEFaturaServis;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class InnovaSendEInvoice : ICommandSendUBL {
        private ClientInterfaceServiceClient _serviceProxy;
        public InvoiceType Invoice { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public Task<ServiceResponse> Result { get; set; }

        public InnovaSendEInvoice(InvoiceType invoiceType) {
            this.Invoice = invoiceType;
        }


        public async Task Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }


            _serviceProxy = InnovaHelper.CreateServiceProxy(ServiceInfo.ServiceUrl, ServiceInfo.UserName, ServiceInfo.Password);

            SendInvoicesRawRequest request = new SendInvoicesRawRequest() {
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

            await _serviceProxy.SendInvoicesRawAsync(request)
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
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
