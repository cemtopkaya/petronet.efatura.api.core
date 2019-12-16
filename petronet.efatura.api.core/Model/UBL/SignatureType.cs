using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureType {

        [XmlElement(Order = 0)]
        public SignedInfoType SignedInfo { get; set; }

        [XmlElement(Order = 1)]
        public SignatureValueType SignatureValue { get; set; }

        [XmlElement(Order = 2)]
        public KeyInfoType KeyInfo { get; set; }

        [XmlElement("Object", Order = 3)]
        public ObjectType[] Object { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}