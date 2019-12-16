using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {


    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PartyType {

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public WebsiteURIType WebsiteURI { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public EndpointIDType EndpointID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public IndustryClassificationCodeType IndustryClassificationCode { get; set; }

        [XmlElement("PartyIdentification", Order = 3)]
        public PartyIdentificationType[] PartyIdentification { get; set; }

        [XmlElement(Order = 4)]
        public PartyNameType PartyName { get; set; }

        [XmlElement(Order = 5)]
        public AddressType PostalAddress { get; set; }

        [XmlElement(Order = 6)]
        public LocationType1 PhysicalLocation { get; set; }

        [XmlElement(Order = 7)]
        public PartyTaxSchemeType PartyTaxScheme { get; set; }

        [XmlElement("PartyLegalEntity", Order = 8)]
        public PartyLegalEntityType[] PartyLegalEntity { get; set; }

        [XmlElement(Order = 9)]
        public ContactType Contact { get; set; }

        [XmlElement(Order = 10)]
        public PersonType Person { get; set; }

        [XmlElement(Order = 11)]
        public PartyType AgentParty { get; set; }
    }
}
