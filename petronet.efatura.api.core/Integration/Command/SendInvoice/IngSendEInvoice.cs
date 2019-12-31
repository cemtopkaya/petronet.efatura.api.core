using System;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using DijitalPlanet.EFaturaEArsiv;
using ING.EFatura;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command.SendInvoice {
    public class IngSendEInvoice<TService> : ICommandSendEInvoice {

        private TService _serviceProxy;
        private Task<ServiceResponse> _result;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }
        public ServiceInfo ServiceInfo { get; set; }

        public IngSendEInvoice(TService serviceProxy,
            InvoiceType invoiceType = null,
            IMapper mapper = null) {
            this.IMapper = mapper;
            this._serviceProxy = serviceProxy;
            this.Invoice = invoiceType;
        }

        public Task<ServiceResponse> TaskResult() => this._result;

        public async Task Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }

            var wsClient = new ClientEInvoiceServicesPortClient();
            //using (new OperationContextScope(wsClient.InnerChannel)) {
            //    string authorization = "UserName:Password";
            //    byte[] byteArray = Encoding.ASCII.GetBytes(authorization);
            //    string base64authorization = Convert.ToBase64String(byteArray);
            //    System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.Headers.Add(Htt pRequestHeader.Authorization, String.Format("Basic {0}", base64authorization));
            //    wsClient.getUserList(new getUserListRequest()); //call the service method
            //}




            var serviceProxy = (_serviceProxy as IntegrationServiceSoap);

            await serviceProxy.GetFormsAuthenticationTicketAsync(
                    this.ServiceInfo.CorporateCode,
                    this.ServiceInfo.UserName,
                    this.ServiceInfo.Password)
                .ContinueWith(d => {
                    if (!d.IsCompletedSuccessfully) throw new Exception("Ticket bilgisi alınırken istisna oldu!");

                    var request = new SendUBLInvoiceRequest() {
                        Ticket = d.Result,
                        CorporateCode = this.ServiceInfo.CorporateCode,
                        InvoiceRawData = Serialization.SerializeToBytes(this.Invoice),
                        MapCode = "",
                        ReceiverPostboxName = this.ServiceInfo.ReceiverPostboxName
                    };

                    return serviceProxy?.SendUBLInvoiceAsync(request);
                })
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
