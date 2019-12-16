using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PackageType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public QuantityType2 Quantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public PackageLevelCodeType PackageLevelCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public PackagingTypeCodeType PackagingTypeCode { get; set; }


        [XmlElement("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public PackingMaterialType[] PackingMaterial { get; set; }


        [XmlElement("ContainedPackage", Order = 6)]
        public PackageType[] ContainedPackage { get; set; }


        [XmlElement("GoodsItem", Order = 7)]
        public GoodsItemType[] GoodsItem { get; set; }


        [XmlElement("MeasurementDimension", Order = 8)]
        public DimensionType[] MeasurementDimension { get; set; }
    }
}