using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petronet.efatura.api.core.UBL
{
    public class Invoice
    {
        public string UBLVersionID { get; set; }
        public string CustomizationID { get; set; }
        public string ProfileID { get; set; }
        public string ID { get; set; }
        public bool CopyIndicator { get; set; }
        public string UUID { get; set; }
        public string IssueDate { get; set; }
        public string IssueTime { get; set; }
        public string InvoiceTypeCode { get; set; }
        public string DocumentCurrencyCode { get; set; }
        public int LineCountNumeric { get; set; }
        public DespatchDocumentReference DespatchDocumentReference { get; set; }
        public Signature Signature { get; set; }
    }
}
