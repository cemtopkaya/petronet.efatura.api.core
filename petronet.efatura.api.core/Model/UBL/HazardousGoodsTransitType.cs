using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class HazardousGoodsTransitType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TransportEmergencyCardCodeType TransportEmergencyCardCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PackingCriteriaCodeType PackingCriteriaCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HazardousRegulationCodeType HazardousRegulationCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public InhalationToxicityZoneCodeType InhalationToxicityZoneCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TransportAuthorizationCodeType TransportAuthorizationCode { get; set; }


        [XmlElement(Order = 5)]
        public TemperatureType MaximumTemperature { get; set; }


        [XmlElement(Order = 6)]
        public TemperatureType MinimumTemperature { get; set; }
    }
}