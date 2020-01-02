/**
 * EFinans App.config Ayarları
 *
 *<system.serviceModel>
 *   <bindings>
 *     <basicHttpBinding>
 *       <binding name="UserServicePortBinding">
 *         <security mode="Transport" />
 *       </binding>
 *       <binding name="ConnectorServicePortBinding">
 *         <security mode="Transport" />
 *       </binding>
 *       <binding name="ConnectorServicePortBinding1" />
 *     </basicHttpBinding>
 *   </bindings>
 *   <client>
 *     <endpoint address="https://erpefaturatest.cs.com.tr:8043/efatura/ws/userService"
 *         binding="basicHttpBinding" bindingConfiguration="UserServicePortBinding"
 *         contract="EFinans.UserService.UserService" name="UserServicePort" />
 *     <endpoint address="https://erpefaturatest.cs.com.tr:8043/efatura/ws/connectorService"
 *         binding="basicHttpBinding" bindingConfiguration="ConnectorServicePortBinding"
 *         contract="EFinans.ConnectorService.ConnectorService" name="ConnectorServicePort" />
 *   </client>
 * </system.serviceModel>
 *
 **/

using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using EFinans.EFatura.ConnectorService;
using EFinans.EFatura.UserService;
using petronet.efatura.api.core.Helper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.ViewModel;
using Exception = System.Exception;
using Hash = petronet.efatura.api.core.Helper.Hash;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {

    public class EFinansSendEInvoice : ICommandSendUBL {

        #region Props & Fields
        private ConnectorServiceClient _connectorWsClient;
        private UserServiceClient _userWsClient;

        public InvoiceType Invoice { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
        public Task<ServiceResponse> Result { get; set; }

        #endregion

        #region Ctors
        public EFinansSendEInvoice(InvoiceType invoiceType) {
            this.Invoice = invoiceType;
        }
        #endregion



        /// <summary>
        /// UserServiceClient ve ConnectorServiceClient sınıflarından nesneler oluşturulur.
        /// Önce wsLogin ile kullanıcı girişi yapılır ve dönen cookie bilgisi connectorService nesnesine her talebi için atanır.
        /// </summary>
        /// <returns>ServiceResponse Türünde yanıt döner</returns>
        public async Task Execute() {

            var result = new ServiceResponse() {
                Hatali = false,
            };

            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }

            try {
                this._connectorWsClient = EFinansHelper.CreateConnectorServiceClient(
                    ServiceInfo.ServiceUrl, 
                    ServiceInfo.UserName, 
                    ServiceInfo.Password);

                this._userWsClient = EFinansHelper.CreateUserServiceClient(
                    ServiceInfo.UserServiceUrl, 
                    ServiceInfo.UserName, 
                    ServiceInfo.Password);

                var cookie = EFinansHelper.GetValidCookie(_userWsClient, ServiceInfo.UserName, ServiceInfo.Password);
                string belgeOid;

                using (new OperationContextScope(_connectorWsClient.InnerChannel)) {
                    var requestProp = new HttpRequestMessageProperty();
                    requestProp.Headers["Set-Cookie"] = cookie;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestProp;

                    var request = PrepareGidenBelgeParametreleri();
                    belgeOid = _connectorWsClient.belgeGonderExt(request);
                }

                result.Sonuc = string.IsNullOrEmpty(belgeOid)
                    ? "İşlem tamamlandı!"
                    : "İşlem başarıyla tamamlandı";
                result.Data = new { belgeOid };

            } catch (Exception ex) {
                result.Hatali = true;
                result.Istisna += ex.ToString();
            }

            this.Result = Task.FromResult(result);
        }


        private gidenBelgeParametreleri PrepareGidenBelgeParametreleri() {
            byte[] barrInvoice = Serialization.SerializeToBytes(this.Invoice);

            var request = new gidenBelgeParametreleri() {
                vergiTcKimlikNo = Invoice.AccountingSupplierParty.Party.PartyIdentification[0].ID.Value,
                belgeTuru = "FATURA_UBL",
                belgeNo = Invoice.ID.Value,
                veri = barrInvoice,
                belgeHash = Hash.HashArray(barrInvoice),
                mimeType = "application/xml",
                belgeVersiyon = "1.2",
                erpKodu = this.ServiceInfo.CorporateCode,
            };
            return request;
        }

        public void Dispose() {
            (this._connectorWsClient as ICommunicationObject)?.Close();
            (this._userWsClient as ICommunicationObject)?.Close();
        }
    }


}
