using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class RSAKeyValueType {

        [XmlElement(DataType = "base64Binary", Order = 0)]
        public byte[] Modulus { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] Exponent { get; set; }
    }
}