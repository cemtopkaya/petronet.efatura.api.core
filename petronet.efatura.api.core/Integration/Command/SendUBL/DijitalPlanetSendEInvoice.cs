using System.ServiceModel;
using System.Threading.Tasks;
using DijitalPlanet.EFaturaEArsiv;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class DijitalPlanetSendEInvoice : ICommandSendUBL {

        private IntegrationServiceSoapClient _serviceProxy;
        public InvoiceType Invoice { get; set; }
        public ServiceInfo ServiceInfo { get; set; }

        public DijitalPlanetSendEInvoice(InvoiceType invoiceType) {
            this.Invoice = invoiceType;
        }

        public Task<ServiceResponse> Result { get; set; }

        public async Task Execute() {

            var result = new ServiceResponse() {
                Hatali = false,
            };

            this._serviceProxy = DijitalPlanetHelper.CreateServiceProxy(
                ServiceInfo.ServiceUrl,
                ServiceInfo.UserName,
                ServiceInfo.Password);

            var ticket = _serviceProxy.GetFormsAuthenticationTicket(
                    this.ServiceInfo.CorporateCode,
                    this.ServiceInfo.UserName,
                    this.ServiceInfo.Password);

            var invoiceRawData = Serialization.SerializeToBytes(this.Invoice);
            var receiverPostboxName = this.ServiceInfo.ReceiverPostboxName;

            var stateResult = _serviceProxy.SendUBLInvoice(ticket, invoiceRawData, this.ServiceInfo.CorporateCode, "", receiverPostboxName);

            result.Sonuc = stateResult.ErrorCode == 0 ? "İşlem başarıyla tamamlandı" : "İşlem tamamlandı!";
            result.Data = stateResult;

            this.Result = Task.FromResult(result);
        }


        public void Dispose() {
            this.Result?.Dispose();
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
