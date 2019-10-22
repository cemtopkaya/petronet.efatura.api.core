using System.Xml.Serialization;

namespace petronet.efatura.api.core.UBL
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    public partial class InvoiceType
    {

        //private UBLExtensionType[] uBLExtensionsField;

        //private UBLVersionIDType uBLVersionIDField;

        //private CustomizationIDType customizationIDField;

        //private ProfileIDType profileIDField;

        //private IDType idField;

        //private CopyIndicatorType copyIndicatorField;

        //private UUIDType uUIDField;

        //private IssueDateType issueDateField;

        //private IssueTimeType issueTimeField;

        //private InvoiceTypeCodeType invoiceTypeCodeField;

        //private NoteType[] noteField;

        //private DocumentCurrencyCodeType documentCurrencyCodeField;

        //private TaxCurrencyCodeType taxCurrencyCodeField;

        //private PricingCurrencyCodeType pricingCurrencyCodeField;

        //private PaymentCurrencyCodeType paymentCurrencyCodeField;

        //private PaymentAlternativeCurrencyCodeType paymentAlternativeCurrencyCodeField;

        //private AccountingCostType accountingCostField;

        //private LineCountNumericType lineCountNumericField;

        //private PeriodType invoicePeriodField;

        //private OrderReferenceType orderReferenceField;

        //private BillingReferenceType[] billingReferenceField;

        //private DocumentReferenceType[] despatchDocumentReferenceField;

        //private DocumentReferenceType[] receiptDocumentReferenceField;

        //private DocumentReferenceType[] originatorDocumentReferenceField;

        //private DocumentReferenceType[] contractDocumentReferenceField;

        //private DocumentReferenceType[] additionalDocumentReferenceField;

        //private SignatureType1[] signatureField;

        //private SupplierPartyType accountingSupplierPartyField;

        //private CustomerPartyType accountingCustomerPartyField;

        //private CustomerPartyType buyerCustomerPartyField;

        //private SupplierPartyType sellerSupplierPartyField;

        //private PartyType taxRepresentativePartyField;

        //private DeliveryType[] deliveryField;

        //private PaymentMeansType[] paymentMeansField;

        //private PaymentTermsType paymentTermsField;

        //private AllowanceChargeType[] allowanceChargeField;

        //private ExchangeRateType taxExchangeRateField;

        //private ExchangeRateType pricingExchangeRateField;

        //private ExchangeRateType paymentExchangeRateField;

        //private ExchangeRateType paymentAlternativeExchangeRateField;

        //private TaxTotalType[] taxTotalField;

        //private TaxTotalType[] withholdingTaxTotalField;

        //private MonetaryTotalType legalMonetaryTotalField;

        //private InvoiceLineType[] invoiceLineField;

        //private string schemaLocationField;

        ///// <remarks/>
        //[System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order = 0)]
        //[System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
        //public UBLExtensionType[] UBLExtensions {
        //    get {
        //        return this.uBLExtensionsField;
        //    }
        //    set {
        //        this.uBLExtensionsField = value;
        //    }
        //}

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public UBLVersionIDType UBLVersionID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public CustomizationIDType CustomizationID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ProfileIDType ProfileID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public IDType ID { get; set; }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        //public CopyIndicatorType CopyIndicator {
        //    get {
        //        return this.copyIndicatorField;
        //    }
        //    set {
        //        this.copyIndicatorField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        //public UUIDType UUID {
        //    get {
        //        return this.uUIDField;
        //    }
        //    set {
        //        this.uUIDField = value;
        //    }
        //}

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public IssueDateType IssueDate {get;set;}

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public IssueTimeType IssueTime { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public InvoiceTypeCodeType InvoiceTypeCode { get; set; }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        //public NoteType[] Note {
        //    get {
        //        return this.noteField;
        //    }
        //    set {
        //        this.noteField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        //public DocumentCurrencyCodeType DocumentCurrencyCode {
        //    get {
        //        return this.documentCurrencyCodeField;
        //    }
        //    set {
        //        this.documentCurrencyCodeField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        //public TaxCurrencyCodeType TaxCurrencyCode {
        //    get {
        //        return this.taxCurrencyCodeField;
        //    }
        //    set {
        //        this.taxCurrencyCodeField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        //public PricingCurrencyCodeType PricingCurrencyCode {
        //    get {
        //        return this.pricingCurrencyCodeField;
        //    }
        //    set {
        //        this.pricingCurrencyCodeField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        //public PaymentCurrencyCodeType PaymentCurrencyCode {
        //    get {
        //        return this.paymentCurrencyCodeField;
        //    }
        //    set {
        //        this.paymentCurrencyCodeField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 15)]
        //public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode {
        //    get {
        //        return this.paymentAlternativeCurrencyCodeField;
        //    }
        //    set {
        //        this.paymentAlternativeCurrencyCodeField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 16)]
        //public AccountingCostType AccountingCost {
        //    get {
        //        return this.accountingCostField;
        //    }
        //    set {
        //        this.accountingCostField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 17)]
        //public LineCountNumericType LineCountNumeric {
        //    get {
        //        return this.lineCountNumericField;
        //    }
        //    set {
        //        this.lineCountNumericField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 18)]
        //public PeriodType InvoicePeriod {
        //    get {
        //        return this.invoicePeriodField;
        //    }
        //    set {
        //        this.invoicePeriodField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 19)]
        //public OrderReferenceType OrderReference {
        //    get {
        //        return this.orderReferenceField;
        //    }
        //    set {
        //        this.orderReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 20)]
        //public BillingReferenceType[] BillingReference {
        //    get {
        //        return this.billingReferenceField;
        //    }
        //    set {
        //        this.billingReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 21)]
        //public DocumentReferenceType[] DespatchDocumentReference {
        //    get {
        //        return this.despatchDocumentReferenceField;
        //    }
        //    set {
        //        this.despatchDocumentReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 22)]
        //public DocumentReferenceType[] ReceiptDocumentReference {
        //    get {
        //        return this.receiptDocumentReferenceField;
        //    }
        //    set {
        //        this.receiptDocumentReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 23)]
        //public DocumentReferenceType[] OriginatorDocumentReference {
        //    get {
        //        return this.originatorDocumentReferenceField;
        //    }
        //    set {
        //        this.originatorDocumentReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 24)]
        //public DocumentReferenceType[] ContractDocumentReference {
        //    get {
        //        return this.contractDocumentReferenceField;
        //    }
        //    set {
        //        this.contractDocumentReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 25)]
        //public DocumentReferenceType[] AdditionalDocumentReference {
        //    get {
        //        return this.additionalDocumentReferenceField;
        //    }
        //    set {
        //        this.additionalDocumentReferenceField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 26)]
        //public SignatureType1[] Signature {
        //    get {
        //        return this.signatureField;
        //    }
        //    set {
        //        this.signatureField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 27)]
        //public SupplierPartyType AccountingSupplierParty {
        //    get {
        //        return this.accountingSupplierPartyField;
        //    }
        //    set {
        //        this.accountingSupplierPartyField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 28)]
        //public CustomerPartyType AccountingCustomerParty {
        //    get {
        //        return this.accountingCustomerPartyField;
        //    }
        //    set {
        //        this.accountingCustomerPartyField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 29)]
        //public CustomerPartyType BuyerCustomerParty {
        //    get {
        //        return this.buyerCustomerPartyField;
        //    }
        //    set {
        //        this.buyerCustomerPartyField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 30)]
        //public SupplierPartyType SellerSupplierParty {
        //    get {
        //        return this.sellerSupplierPartyField;
        //    }
        //    set {
        //        this.sellerSupplierPartyField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 31)]
        //public PartyType TaxRepresentativeParty {
        //    get {
        //        return this.taxRepresentativePartyField;
        //    }
        //    set {
        //        this.taxRepresentativePartyField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 32)]
        //public DeliveryType[] Delivery {
        //    get {
        //        return this.deliveryField;
        //    }
        //    set {
        //        this.deliveryField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 33)]
        //public PaymentMeansType[] PaymentMeans {
        //    get {
        //        return this.paymentMeansField;
        //    }
        //    set {
        //        this.paymentMeansField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 34)]
        //public PaymentTermsType PaymentTerms {
        //    get {
        //        return this.paymentTermsField;
        //    }
        //    set {
        //        this.paymentTermsField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 35)]
        //public AllowanceChargeType[] AllowanceCharge {
        //    get {
        //        return this.allowanceChargeField;
        //    }
        //    set {
        //        this.allowanceChargeField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 36)]
        //public ExchangeRateType TaxExchangeRate {
        //    get {
        //        return this.taxExchangeRateField;
        //    }
        //    set {
        //        this.taxExchangeRateField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 37)]
        //public ExchangeRateType PricingExchangeRate {
        //    get {
        //        return this.pricingExchangeRateField;
        //    }
        //    set {
        //        this.pricingExchangeRateField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 38)]
        //public ExchangeRateType PaymentExchangeRate {
        //    get {
        //        return this.paymentExchangeRateField;
        //    }
        //    set {
        //        this.paymentExchangeRateField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 39)]
        //public ExchangeRateType PaymentAlternativeExchangeRate {
        //    get {
        //        return this.paymentAlternativeExchangeRateField;
        //    }
        //    set {
        //        this.paymentAlternativeExchangeRateField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 40)]
        //public TaxTotalType[] TaxTotal {
        //    get {
        //        return this.taxTotalField;
        //    }
        //    set {
        //        this.taxTotalField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 41)]
        //public TaxTotalType[] WithholdingTaxTotal {
        //    get {
        //        return this.withholdingTaxTotalField;
        //    }
        //    set {
        //        this.withholdingTaxTotalField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 42)]
        //public MonetaryTotalType LegalMonetaryTotal {
        //    get {
        //        return this.legalMonetaryTotalField;
        //    }
        //    set {
        //        this.legalMonetaryTotalField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 43)]
        //public InvoiceLineType[] InvoiceLine {
        //    get {
        //        return this.invoiceLineField;
        //    }
        //    set {
        //        this.invoiceLineField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public string schemaLocation {
        //    get {
        //        return this.schemaLocationField;
        //    }
        //    set {
        //        this.schemaLocationField = value;
        //    }
        //}
    }
}
