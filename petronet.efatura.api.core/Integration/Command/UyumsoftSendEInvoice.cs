using System;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using petronet.efatura.api.core.Model;
using uyumsoft;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class UyumsoftSendEInvoice<TService> : ICommandSendEInvoice {

        private TService _serviceProxy;
        private Task<ServiceResponse> _result;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }

        public UyumsoftSendEInvoice(TService serviceProxy, InvoiceType invoiceType = null, IMapper mapper = null) {
            this.IMapper = mapper;
            this._serviceProxy = serviceProxy;
            this.Invoice = invoiceType;
        }

        public Task<ServiceResponse> TaskResult() => this._result;

        public void Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }

            var uyumsoftInvoiceType = IMapper.Map<uyumsoft.InvoiceType>(Invoice);

            InvoiceInfo[] invoices = new[]
            {
                new uyumsoft.InvoiceInfo()
                {
                    Invoice = uyumsoftInvoiceType,
                    LocalDocumentId = "localBelgeAydisi",
                }
            };

            this._result = (_serviceProxy as IIntegration)?.SaveAsDraftAsync(invoices)
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
