using System;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using petronet.efatura.api.core.Integration.Command.Interfaces;
using petronet.efatura.api.core.Model;
using petronet.efatura.api.core.ViewModel;
using uyumsoft= Uyumsoft.EFatura;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command.SendInvoice {
    public class UyumsoftSendEInvoice : ICommandSendEInvoice {

        #region Props & Fields

        private Task<ServiceResponse> _result;
        private uyumsoft.IntegrationClient _serviceProxy;

        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }
        public ServiceInfo ServiceInfo { get; set; }

        #endregion

        public UyumsoftSendEInvoice(InvoiceType invoiceType = null, IMapper mapper = null) {
            this.IMapper = mapper;
            this.Invoice = invoiceType;
        }

        public Task<ServiceResponse> TaskResult() => this._result;

        public async Task Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }

            this._serviceProxy = CreateServiceProxy(ServiceInfo.ServiceUrl, ServiceInfo.UserName, ServiceInfo.Password);

            var uyumsoftInvoiceType = IMapper.Map<uyumsoft.InvoiceType>(Invoice);

            uyumsoft.InvoiceInfo[] invoices = new[]
            {
                new uyumsoft.InvoiceInfo()
                {
                    Invoice = uyumsoftInvoiceType,
                    LocalDocumentId = "localBelgeAydisi",
                }
            };

            this._result = (_serviceProxy as uyumsoft.IIntegration)?.SaveAsDraftAsync(invoices)
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

        private uyumsoft.IntegrationClient CreateServiceProxy(string serviceUrl, string userName, string password) {
            var basicHttpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);
            var endPoint = new EndpointAddress(serviceUrl);

            var proxy = new uyumsoft.IntegrationClient(basicHttpBinding, endPoint);
            proxy.ClientCredentials.UserName.UserName = userName;
            proxy.ClientCredentials.UserName.Password = password;
            return proxy;
        }

        public void Dispose() {
            _result?.Dispose();
            (this._serviceProxy as ICommunicationObject)?.Close();
        }
    }
}
