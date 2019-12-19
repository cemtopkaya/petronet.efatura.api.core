using System;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using petronet.efatura.api.core.Model.UBL;
using petronet.efatura.api.core.ViewModel;

namespace petronet.efatura.api.core.Integration.Command {
    public class ServiceResponse {
        public bool Hatali { get; set; }
        public string Istisna { get; set; }
        public object Data { get; set; }
        public string Sonuc { get; set; }
    }

    interface ICommandSendEInvoice : IDisposable { //where TService: ICommunicationObject
        InvoiceType Invoice { get; set; }
        IMapper IMapper { get; set; }
        ServiceInfo ServiceInfo { get; set; }

        Task<ServiceResponse> TaskResult();

        void Execute();
    }
}
