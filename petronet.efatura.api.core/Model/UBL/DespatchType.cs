using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class DespatchType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ActualDespatchDateType ActualDespatchDate { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ActualDespatchTimeType ActualDespatchTime { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public InstructionsType Instructions { get; set; }


        [XmlElement(Order = 4)]
        public AddressType DespatchAddress { get; set; }


        [XmlElement(Order = 5)]
        public PartyType DespatchParty { get; set; }


        [XmlElement(Order = 6)]
        public ContactType Contact { get; set; }


        [XmlElement(Order = 7)]
        public PeriodType EstimatedDespatchPeriod { get; set; }
    }
}