using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TransportHandlingUnitType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HandlingCodeType HandlingCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public HandlingInstructionsType HandlingInstructions { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public TotalPackageQuantityType TotalPackageQuantity { get; set; }


        [XmlElement("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public DamageRemarksType[] DamageRemarks { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public TraceIDType TraceID { get; set; }


        [XmlElement("ActualPackage", Order = 9)]
        public PackageType[] ActualPackage { get; set; }


        [XmlElement("TransportEquipment", Order = 10)]
        public TransportEquipmentType[] TransportEquipment { get; set; }


        [XmlElement("TransportMeans", Order = 11)]
        public TransportMeansType[] TransportMeans { get; set; }


        [XmlElement("HazardousGoodsTransit", Order = 12)]
        public HazardousGoodsTransitType[] HazardousGoodsTransit { get; set; }


        [XmlElement("MeasurementDimension", Order = 13)]
        public DimensionType[] MeasurementDimension { get; set; }


        [XmlElement(Order = 14)]
        public TemperatureType MinimumTemperature { get; set; }


        [XmlElement(Order = 15)]
        public TemperatureType MaximumTemperature { get; set; }


        [XmlElement(Order = 16)]
        public DimensionType FloorSpaceMeasurementDimension { get; set; }


        [XmlElement(Order = 17)]
        public DimensionType PalletSpaceMeasurementDimension { get; set; }


        [XmlElement("ShipmentDocumentReference", Order = 18)]
        public DocumentReferenceType[] ShipmentDocumentReference { get; set; }


        [XmlElement("CustomsDeclaration", Order = 19)]
        public CustomsDeclarationType[] CustomsDeclaration { get; set; }
    }
}