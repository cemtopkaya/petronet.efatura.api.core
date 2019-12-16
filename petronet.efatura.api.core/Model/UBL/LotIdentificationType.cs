using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class LotIdentificationType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public LotNumberIDType LotNumberID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ExpiryDateType ExpiryDate { get; set; }


        [XmlElement("AdditionalItemProperty", Order = 2)]
        public ItemPropertyType[] AdditionalItemProperty { get; set; }
    }
}