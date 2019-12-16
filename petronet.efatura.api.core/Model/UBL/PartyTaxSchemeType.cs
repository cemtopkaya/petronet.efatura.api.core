using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PartyTaxSchemeType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public RegistrationNameType RegistrationName { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public CompanyIDType CompanyID { get; set; }
        [XmlElement(Order = 2)]
        public TaxSchemeType TaxScheme { get; set; }
    }
}
