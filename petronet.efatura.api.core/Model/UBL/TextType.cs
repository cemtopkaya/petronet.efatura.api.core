using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class TextType {

        [XmlAttribute(DataType = "language")]
        public string languageID { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string languageLocaleID { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
