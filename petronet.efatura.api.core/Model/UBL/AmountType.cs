using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {


    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class AmountType {

        [XmlAttribute(DataType = "normalizedString")]
        public string currencyID { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string currencyCodeListVersionID { get; set; }

        [XmlText()]
        public decimal Value { get; set; }
    }
}
