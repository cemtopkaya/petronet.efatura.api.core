using System;
using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    //[Serializable]
    //[XmlRoot(
    //    Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
    //    ElementName = "Invoice",
    //    DataType = "string",
    //    IsNullable = true)]
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    [XmlRoot("Invoice",Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
    public class InvoiceType {


//        private XmlSerializerNamespaces xmlns;

//        [XmlNamespaceDeclarations]
//        public XmlSerializerNamespaces Xmlns {
//            get {
//                if (xmlns == null) {
//                    xmlns = new XmlSerializerNamespaces();

//                    /*
//-<Invoice xmlns:xades="http://uri.etsi.org/01903/v1.3.2#" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" xmlns:ubltr="urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents" xmlns:cctc="urn:un:unece:uncefact:documentation:2" xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
//                     *
//                     */
//                    xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
//                    xmlns.Add("xsd", "http://www.w3.org/2001/XMLSchema");

//                    xmlns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
//                    xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
//                    xmlns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
//                    xmlns.Add("cctc", "urn:un:unece:uncefact:documentation:2");
//                    xmlns.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
//                    xmlns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
//                    xmlns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
//                    xmlns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
//                    xmlns.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
//                }
//                return xmlns;
//            }
//            set { xmlns = value; }
//        }


        [XmlArray(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order = 0)]
        [XmlArrayItem("UBLExtension", IsNullable = false)]
        public UBLExtensionType[] UBLExtensions { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public UBLVersionIDType UBLVersionID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public CustomizationIDType CustomizationID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ProfileIDType ProfileID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public IDType ID { get; set; }

        [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public NoteType[] Note { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CopyIndicatorType CopyIndicator { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public UUIDType UUID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public IssueDateType IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public IssueTimeType IssueTime { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public InvoiceTypeCodeType InvoiceTypeCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public DocumentCurrencyCodeType DocumentCurrencyCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public TaxCurrencyCodeType TaxCurrencyCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public PricingCurrencyCodeType PricingCurrencyCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        public PaymentCurrencyCodeType PaymentCurrencyCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 15)]
        public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 16)]
        public AccountingCostType AccountingCost { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 17)]
        public LineCountNumericType LineCountNumeric { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 18)]
        public PeriodType InvoicePeriod { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 19)]
        public OrderReferenceType OrderReference { get; set; }

        [XmlElement("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 20)]
        public BillingReferenceType[] BillingReference { get; set; }

        [XmlElement("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 21)]
        public DocumentReferenceType[] DespatchDocumentReference { get; set; }

        [XmlElement("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 22)]
        public DocumentReferenceType[] ReceiptDocumentReference { get; set; }

        [XmlElement("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 23)]
        public DocumentReferenceType[] OriginatorDocumentReference { get; set; }

        [XmlElement("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 24)]
        public DocumentReferenceType[] ContractDocumentReference { get; set; }

        [XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 25)]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

        [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 26)]
        public SignatureType1[] Signature { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 27)]
        public SupplierPartyType AccountingSupplierParty { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 28)]
        public CustomerPartyType AccountingCustomerParty { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 29)]
        public CustomerPartyType BuyerCustomerParty { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 30)]
        public SupplierPartyType SellerSupplierParty { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 31)]
        public PartyType TaxRepresentativeParty { get; set; }

        [XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 32)]
        public DeliveryType[] Delivery { get; set; }

        [XmlElement("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 33)]
        public PaymentMeansType[] PaymentMeans { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 34)]
        public PaymentTermsType PaymentTerms { get; set; }

        [XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 35)]
        public AllowanceChargeType[] AllowanceCharge { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 36)]
        public ExchangeRateType TaxExchangeRate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 37)]
        public ExchangeRateType PricingExchangeRate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 38)]
        public ExchangeRateType PaymentExchangeRate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 39)]
        public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 40)]
        public TaxTotalType[] TaxTotal { get; set; }

        [XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 41)]
        public TaxTotalType[] WithholdingTaxTotal { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 42)]
        public MonetaryTotalType LegalMonetaryTotal { get; set; }

        [XmlElement("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 43)]
        public InvoiceLineType[] InvoiceLine { get; set; }

        [XmlAttribute()]
        public string schemaLocation { get; set; }
    }
}
