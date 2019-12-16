using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {


    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PartyLegalEntityType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public RegistrationNameType RegistrationName { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public CompanyIDType CompanyID { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RegistrationDateType RegistrationDate { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public SoleProprietorshipIndicatorType SoleProprietorshipIndicator { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public CorporateStockAmountType CorporateStockAmount { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public FullyPaidSharesIndicatorType FullyPaidSharesIndicator { get; set; }
        [XmlElement(Order = 6)]
        public CorporateRegistrationSchemeType CorporateRegistrationScheme { get; set; }
        [XmlElement(Order = 7)]
        public PartyType HeadOfficeParty { get; set; }
    }
}
