using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class GoodsItemType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public DescriptionType[] Description { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public InsuranceValueAmountType InsuranceValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public ValueAmountType ValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public GrossWeightMeasureType GrossWeightMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public NetWeightMeasureType NetWeightMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public ChargeableWeightMeasureType ChargeableWeightMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public GrossVolumeMeasureType GrossVolumeMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public NetVolumeMeasureType NetVolumeMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        public QuantityType2 Quantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 15)]
        public RequiredCustomsIDType RequiredCustomsID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 16)]
        public CustomsStatusCodeType CustomsStatusCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 17)]
        public CustomsTariffQuantityType CustomsTariffQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 18)]
        public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 19)]
        public ChargeableQuantityType ChargeableQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 20)]
        public ReturnableQuantityType ReturnableQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 21)]
        public TraceIDType TraceID { get; set; }


        [XmlElement("Item", Order = 22)]
        public ItemType[] Item { get; set; }


        [XmlElement("FreightAllowanceCharge", Order = 23)]
        public AllowanceChargeType[] FreightAllowanceCharge { get; set; }


        [XmlElement("InvoiceLine", Order = 24)]
        public InvoiceLineType[] InvoiceLine { get; set; }


        [XmlElement("Temperature", Order = 25)]
        public TemperatureType[] Temperature { get; set; }


        [XmlElement(Order = 26)]
        public AddressType OriginAddress { get; set; }


        [XmlElement("MeasurementDimension", Order = 27)]
        public DimensionType[] MeasurementDimension { get; set; }
    }
}