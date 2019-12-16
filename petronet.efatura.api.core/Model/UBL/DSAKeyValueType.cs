using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class DSAKeyValueType {

        [XmlElement(DataType = "base64Binary", Order = 0)]
        public byte[] P { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] Q { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 2)]
        public byte[] G { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 3)]
        public byte[] Y { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 4)]
        public byte[] J { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 5)]
        public byte[] Seed { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 6)]
        public byte[] PgenCounter { get; set; }
    }
}