using Microsoft.AspNetCore.Mvc;
using petronet.efatura.api.core.UBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petronet.efatura.api.core.Controllers
{
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
