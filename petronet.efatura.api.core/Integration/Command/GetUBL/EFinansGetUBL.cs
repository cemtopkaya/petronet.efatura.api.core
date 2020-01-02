using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using EFinans.EFatura.ConnectorService;
using ING.EFatura;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command.GetUBL {
    public class EFinansGetUBL : ICommandGetUBL {

        private Task<ServiceResponse> _result;
        private string[] UUIDs;
        private ConnectorServiceClient _serviceProxy;
        public ServiceInfo ServiceInfo { get; set; }
        public Task<ServiceResponse> Result { get; set; }

        public EFinansGetUBL(string[] uuid) {
            this.UUIDs = uuid;
        }


        public async Task Execute() {
            var serviceResponse = new ServiceResponse() {
                Hatali = false,
            };

            _serviceProxy = EFinansHelper.CreateConnectorServiceClient(
                ServiceInfo.ServiceUrl, 
                ServiceInfo.UserName,
                ServiceInfo.Password);

            string vergiTcKimlikNo = ServiceInfo.SupplierVkn;
            string[] ettnler = this.UUIDs; //new string[] { "291DB9EC-4FC4-4F7E-BDD2-C5C54F62A635", "3e60aad6-48cc-4f76-a20c-5fc892d1a837" };
            string belgeTuru = "FATURA";        // "FATURA" ve "UYGULAMA_YANITI"
            string belgeFormati = "UBL";        // "HTML", "PDF", "UBL"
            byte[] ublZip = _serviceProxy.gelenBelgeleriIndir(vergiTcKimlikNo, ettnler, belgeTuru, belgeFormati);

            serviceResponse.Sonuc = "UBL Başarıyla alındı";
            serviceResponse.Data = ublZip;
            this.Result = Task.FromResult(serviceResponse);
        }

        public void Dispose() {
            _result?.Dispose();
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
