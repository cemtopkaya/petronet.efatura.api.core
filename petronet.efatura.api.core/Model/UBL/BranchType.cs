using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {


    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class BranchType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NameType1 Name { get; set; }
        [XmlElement(Order = 1)]
        public FinancialInstitutionType FinancialInstitution { get; set; }
    }
}
