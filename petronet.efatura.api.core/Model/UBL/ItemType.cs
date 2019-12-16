using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ItemType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public DescriptionType Description { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NameType1 Name { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public KeywordType Keyword { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public BrandNameType BrandName { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ModelNameType ModelName { get; set; }


        [XmlElement(Order = 5)]
        public ItemIdentificationType BuyersItemIdentification { get; set; }


        [XmlElement(Order = 6)]
        public ItemIdentificationType SellersItemIdentification { get; set; }


        [XmlElement(Order = 7)]
        public ItemIdentificationType ManufacturersItemIdentification { get; set; }


        [XmlElement("AdditionalItemIdentification", Order = 8)]
        public ItemIdentificationType[] AdditionalItemIdentification { get; set; }


        [XmlElement(Order = 9)]
        public CountryType OriginCountry { get; set; }


        [XmlElement("CommodityClassification", Order = 10)]
        public CommodityClassificationType[] CommodityClassification { get; set; }


        [XmlElement("ItemInstance", Order = 11)]
        public ItemInstanceType[] ItemInstance { get; set; }
    }
}