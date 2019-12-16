using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureMethodType {

        [XmlElement(DataType = "integer", Order = 0)]
        public string HMACOutputLength { get; set; }

        [XmlText()]
        [XmlAnyElement(Order = 1)]
        public System.Xml.XmlNode[] Any { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }
}