using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class MeasureType {
        [XmlAttribute(DataType = "normalizedString")]
        public string unitCode { get; set; }
        [XmlAttribute(DataType = "normalizedString")]
        public string unitCodeListVersionID { get; set; }
        [XmlText()]
        public decimal Value { get; set; }
    }
}
