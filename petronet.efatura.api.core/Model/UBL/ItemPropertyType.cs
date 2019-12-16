using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ItemPropertyType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NameType1 Name { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public NameCodeType NameCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TestMethodType TestMethod { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ValueType Value { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ValueQuantityType ValueQuantity { get; set; }


        [XmlElement("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ValueQualifierType[] ValueQualifier { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public ImportanceCodeType ImportanceCode { get; set; }


        [XmlElement("ListValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public ListValueType[] ListValue { get; set; }


        [XmlElement(Order = 9)]
        public PeriodType UsabilityPeriod { get; set; }


        [XmlElement("ItemPropertyGroup", Order = 10)]
        public ItemPropertyGroupType[] ItemPropertyGroup { get; set; }


        [XmlElement(Order = 11)]
        public DimensionType RangeDimension { get; set; }


        [XmlElement(Order = 12)]
        public ItemPropertyRangeType ItemPropertyRange { get; set; }
    }
}