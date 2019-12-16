using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TransportMeansType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public JourneyIDType JourneyID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public RegistrationNationalityIDType RegistrationNationalityID { get; set; }


        [XmlElement("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RegistrationNationalityType[] RegistrationNationality { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DirectionCodeType DirectionCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TransportMeansTypeCodeType TransportMeansTypeCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TradeServiceCodeType TradeServiceCode { get; set; }


        [XmlElement(Order = 6)]
        public StowageType Stowage { get; set; }


        [XmlElement(Order = 7)]
        public AirTransportType AirTransport { get; set; }


        [XmlElement(Order = 8)]
        public RoadTransportType RoadTransport { get; set; }


        [XmlElement(Order = 9)]
        public RailTransportType RailTransport { get; set; }


        [XmlElement(Order = 10)]
        public MaritimeTransportType MaritimeTransport { get; set; }


        [XmlElement(Order = 11)]
        public PartyType OwnerParty { get; set; }


        [XmlElement("MeasurementDimension", Order = 12)]
        public DimensionType[] MeasurementDimension { get; set; }
    }
}