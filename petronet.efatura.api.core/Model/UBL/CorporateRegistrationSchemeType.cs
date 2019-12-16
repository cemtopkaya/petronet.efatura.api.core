using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {


    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class CorporateRegistrationSchemeType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NameType1 Name { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode { get; set; }
        [XmlElement("JurisdictionRegionAddress", Order = 3)]
        public AddressType[] JurisdictionRegionAddress { get; set; }
    }
}
