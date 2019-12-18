using System.Threading.Tasks;
using AutoMapper;
using petronet.efatura.api.core.Model.UBL;

namespace petronet.efatura.api.core.Integration.Command {
    interface ICommandSendEInvoice<T>
    {
        InvoiceType Invoice { get; set; }
        IMapper IMapper { get; set; }

        Task<T> TaskResult();

        void Execute();
    }
}
