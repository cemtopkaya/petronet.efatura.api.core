using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureValueType {

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlText(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}