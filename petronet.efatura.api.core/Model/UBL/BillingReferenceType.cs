using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class BillingReferenceType {

        /// <remarks/>
        [XmlElement(Order = 0)]
        public DocumentReferenceType InvoiceDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement(Order = 1)]
        public DocumentReferenceType SelfBilledInvoiceDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement(Order = 2)]
        public DocumentReferenceType CreditNoteDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement(Order = 3)]
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement(Order = 4)]
        public DocumentReferenceType DebitNoteDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement(Order = 5)]
        public DocumentReferenceType ReminderDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement(Order = 6)]
        public DocumentReferenceType AdditionalDocumentReference { get; set; }

        /// <remarks/>
        [XmlElement("BillingReferenceLine", Order = 7)]
        public BillingReferenceLineType[] BillingReferenceLine { get; set; }
    }
}