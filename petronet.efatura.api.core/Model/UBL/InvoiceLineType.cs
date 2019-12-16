using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class InvoiceLineType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NoteType[] Note { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public InvoicedQuantityType InvoicedQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LineExtensionAmountType LineExtensionAmount { get; set; }


        [XmlElement("OrderLineReference", Order = 4)]
        public OrderLineReferenceType[] OrderLineReference { get; set; }


        [XmlElement("DespatchLineReference", Order = 5)]
        public LineReferenceType[] DespatchLineReference { get; set; }


        [XmlElement("ReceiptLineReference", Order = 6)]
        public LineReferenceType[] ReceiptLineReference { get; set; }


        [XmlElement("Delivery", Order = 7)]
        public DeliveryType[] Delivery { get; set; }


        [XmlElement("AllowanceCharge", Order = 8)]
        public AllowanceChargeType[] AllowanceCharge { get; set; }


        [XmlElement(Order = 9)]
        public TaxTotalType TaxTotal { get; set; }


        [XmlElement("WithholdingTaxTotal", Order = 10)]
        public TaxTotalType[] WithholdingTaxTotal { get; set; }


        [XmlElement(Order = 11)]
        public ItemType Item { get; set; }


        [XmlElement(Order = 12)]
        public PriceType Price { get; set; }


        [XmlElement("SubInvoiceLine", Order = 13)]
        public InvoiceLineType[] SubInvoiceLine { get; set; }
    }
}