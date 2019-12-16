using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {


    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class BinaryObjectType {

        [XmlAttribute()]
        public string format { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string mimeCode { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string encodingCode { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string characterSetCode { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string uri { get; set; }

        [XmlAttribute()]
        public string filename { get; set; }

        [XmlText(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}
