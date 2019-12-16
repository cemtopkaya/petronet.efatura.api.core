using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PaymentMeansType {

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public PaymentMeansCodeType PaymentMeansCode { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PaymentDueDateType PaymentDueDate { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PaymentChannelCodeType PaymentChannelCode { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public InstructionNoteType InstructionNote { get; set; }

        /// <remarks/>
        [XmlElement(Order = 4)]
        public FinancialAccountType PayerFinancialAccount { get; set; }

        /// <remarks/>
        [XmlElement(Order = 5)]
        public FinancialAccountType PayeeFinancialAccount { get; set; }
    }
}