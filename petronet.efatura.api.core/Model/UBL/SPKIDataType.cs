using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SPKIDataType {

        [XmlElement("SPKISexp", DataType = "base64Binary", Order = 0)]
        public byte[][] SPKISexp { get; set; }

        [XmlAnyElement(Order = 1)]
        public System.Xml.XmlElement Any { get; set; }
    }
}