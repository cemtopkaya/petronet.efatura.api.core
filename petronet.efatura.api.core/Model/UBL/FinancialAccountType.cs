using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class FinancialAccountType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public CurrencyCodeType CurrencyCode { get; set; }
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PaymentNoteType PaymentNote { get; set; }
        [XmlElement(Order = 3)]
        public BranchType FinancialInstitutionBranch { get; set; }
    }

}
