using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class CanonicalizationMethodType {

        [XmlText()]
        [XmlAnyElement(Order = 0)]
        public System.Xml.XmlNode[] Any { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }
}