using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyValueType {

        [XmlAnyElement(Order = 0)]
        [XmlElement("DSAKeyValue", typeof(DSAKeyValueType), Order = 0)]
        [XmlElement("RSAKeyValue", typeof(RSAKeyValueType), Order = 0)]
        public object Item { get; set; }

        [XmlText()]
        public string[] Text { get; set; }
    }
}