using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class ReferenceType {

        [XmlArray(Order = 0)]
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms { get; set; }

        [XmlElement(Order = 1)]
        public DigestMethodType DigestMethod { get; set; }

        [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class DigestMethodType {

            [XmlText()]
            [XmlAnyElement(Order = 0)]
            public System.Xml.XmlNode[] Any { get; set; }

            [XmlAttribute(DataType = "anyURI")]
            public string Algorithm { get; set; }
        }

        [XmlElement(DataType = "base64Binary", Order = 2)]
        public byte[] DigestValue { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string URI { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string Type { get; set; }
    }
}