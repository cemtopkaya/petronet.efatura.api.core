using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PaymentTermsType {

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NoteType Note { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PenaltySurchargePercentType PenaltySurchargePercent { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public AmountType2 Amount { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public PenaltyAmountType PenaltyAmount { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public PaymentDueDateType PaymentDueDate { get; set; }

        /// <remarks/>
        [XmlElement(Order = 5)]
        public PeriodType SettlementPeriod { get; set; }
    }
}