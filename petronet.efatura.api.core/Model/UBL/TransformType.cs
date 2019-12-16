using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class TransformType {

        [XmlAnyElement(Order = 0)]
        [XmlElement("XPath", typeof(string), Order = 0)]
        public object[] Items { get; set; }

        [XmlText()]
        public string[] Text { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }
}