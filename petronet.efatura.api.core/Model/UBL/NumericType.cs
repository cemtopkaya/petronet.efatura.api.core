using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class NumericType {
        [XmlAttribute()]
        public string format { get; set; }

        [XmlText()]
        public decimal Value { get; set; }
    }
}
