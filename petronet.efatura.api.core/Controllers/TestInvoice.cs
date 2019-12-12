using Microsoft.AspNetCore.Mvc;
using petronet.efatura.api.core.Model.UBL;

namespace petronet.efatura.api.core.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class TestInvoice:ControllerBase
    {
        [HttpPost]
        public void SendInvoice(InvoiceInfo invoice)
        {

        }
    }
}
