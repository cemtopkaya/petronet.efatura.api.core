using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uyumsoft;

namespace petronet.efatura.api.core.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        [Produces("application/xml")]
        public IActionResult Get()
        {
            var ii = new UBL.InvoiceInfo
            {
                Invoice = new UBL.InvoiceType
                {
                    ID = new UBL.IDType
                    {
                        schemeID = "VKN",
                        Value = "123123"
                    },
                    ProfileID = new UBL.ProfileIDType { Value = "TICARIFATURA" },
                    UBLVersionID = new UBL.UBLVersionIDType { Value = "2.1" },
                    CustomizationID = new UBL.CustomizationIDType { Value = "TR1.2" },
                    IssueDate = new UBL.IssueDateType { Value = DateTime.Parse("2009-01-05") },
                    IssueTime = new UBL.IssueTimeType { Value = DateTime.Parse("14:42:00") },
                    InvoiceTypeCode = new UBL.InvoiceTypeCodeType { Value = "SATIS" }
                }
            };
            return Ok(ii);
        }
    }
}