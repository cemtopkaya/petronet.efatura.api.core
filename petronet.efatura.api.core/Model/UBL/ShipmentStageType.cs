using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ShipmentStageType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TransportModeCodeType TransportModeCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TransportMeansTypeCodeType TransportMeansTypeCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TransitDirectionCodeType TransitDirectionCode { get; set; }


        [XmlElement("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public InstructionsType[] Instructions { get; set; }


        [XmlElement(Order = 5)]
        public PeriodType TransitPeriod { get; set; }


        [XmlElement(Order = 6)]
        public TransportMeansType TransportMeans { get; set; }


        [XmlElement("DriverPerson", Order = 7)]
        public PersonType[] DriverPerson { get; set; }
    }
}