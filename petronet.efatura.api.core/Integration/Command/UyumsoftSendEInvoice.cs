using System;
using System.Threading.Tasks;
using AutoMapper;
using petronet.efatura.api.core.Model;
using uyumsoft;
using InvoiceType = petronet.efatura.api.core.Model.UBL.InvoiceType;

namespace petronet.efatura.api.core.Integration.Command {
    public class UyumsoftSendEInvoice : ICommandSendEInvoice<InvoiceIdentitiesResponse> {

        private IIntegration _serviceProxy;
        private Task<InvoiceIdentitiesResponse> _result;
        public InvoiceType Invoice { get; set; }
        public IMapper IMapper { get; set; }

        public UyumsoftSendEInvoice(IIntegration serviceProxy, InvoiceType invoiceType = null, IMapper mapper = null) {

            this.IMapper = mapper;
            this._serviceProxy = serviceProxy;
            this.Invoice = invoiceType;
        }

        public Task<InvoiceIdentitiesResponse> TaskResult() {
            Console.WriteLine("hede");
            return _result;
        }

        public void Execute() {
            if (Invoice == null) { throw new ArgumentNullException("Invoice boş olamaz!"); }

            var uyumsoftInvoiceType = IMapper.Map<uyumsoft.InvoiceType>(Invoice);

            this._result = _serviceProxy.SaveAsDraftAsync(new[]
            {
                new uyumsoft.InvoiceInfo()
                {
                    Invoice = uyumsoftInvoiceType,
                    LocalDocumentId = "localBelgeAydisi",
                }
            });
        }
    }
}
