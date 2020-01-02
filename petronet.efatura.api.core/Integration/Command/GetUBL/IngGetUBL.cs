using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using ING.EFatura;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command.GetUBL {
    public class IngGetUBL : ICommandGetUBL {

        private Task<ServiceResponse> _result;
        private ClientEInvoiceServicesPortClient _serviceProxy;
        private string[] UUIDs;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public Task<ServiceResponse> Result { get; set; }

        public IngGetUBL(string[] uuid, IMapper mapper = null) {

            this.IMapper = mapper;
            this.UUIDs = uuid;
        }


        public async Task Execute() {
            var serviceResponse = new ServiceResponse() {
                Hatali = false,
            };

            _serviceProxy = new ClientEInvoiceServicesPortClient();
            getUBLRequest request = new getUBLRequest() {
                Identifier = this.ServiceInfo.SupplierPB,
                Type = "INBOUND",
                Parameters = new[] { "zip" },
                DocType = "INVOICE",
                VKN_TCKN = ServiceInfo.SupplierVkn,
                UUID = this.UUIDs
            };
            var ubl = _serviceProxy.getUBL(request);

            serviceResponse.Sonuc = "UBL Başarıyla alındı";
            serviceResponse.Data = ubl[0];
            this.Result = Task.FromResult(serviceResponse);
        }

        public void Dispose() {
            _result?.Dispose();
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
