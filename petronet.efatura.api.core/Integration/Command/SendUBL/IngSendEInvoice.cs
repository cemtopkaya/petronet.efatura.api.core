using System;
using System.ServiceModel;
using System.Threading.Tasks;
using ING.EFatura;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class IngSendEInvoice : ICommandSendUBL {

        private ClientEInvoiceServicesPortClient _serviceProxy;
        public InvoiceType Invoice { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public Task<ServiceResponse> Result { get; set; }

        public IngSendEInvoice(InvoiceType invoiceType) {
            this.Invoice = invoiceType;
        }

        public async Task Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }

            var result = new ServiceResponse() {
                Hatali = false,
            };

            _serviceProxy = IngHelper.CreateServiceProxy(
                ServiceInfo.ServiceUrl,
                ServiceInfo.UserName,
                ServiceInfo.Password);

            var request = new sendUBLRequest() {
                DocData = Serialization.SerializeToBytes(this.Invoice),
                SenderIdentifier = this.ServiceInfo.SupplierPB,
                ReceiverIdentifier = this.ServiceInfo.CustomerPB,
                DocType = "INVOICE",
                VKN_TCKN = Invoice.AccountingSupplierParty.Party.PartyIdentification[0].ID.Value,
            };
            SendUBLResponseType[] response = _serviceProxy.sendUBL(request);

            result.Sonuc = response.Length > 0 ? "İşlem başarıyla tamamlandı" : "İşlem tamamlandı!";
            result.Data = new { IntegratorResponse = response };
            this.Result = Task.FromResult(result);
        }

        public void Dispose() {
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
