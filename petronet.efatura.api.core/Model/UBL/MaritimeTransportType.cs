using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class MaritimeTransportType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public VesselIDType VesselID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public VesselNameType VesselName { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RadioCallSignIDType RadioCallSignID { get; set; }


        [XmlElement("ShipsRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ShipsRequirementsType[] ShipsRequirements { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public GrossTonnageMeasureType GrossTonnageMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public NetTonnageMeasureType NetTonnageMeasure { get; set; }


        [XmlElement(Order = 6)]
        public DocumentReferenceType RegistryCertificateDocumentReference { get; set; }


        [XmlElement(Order = 7)]
        public LocationType1 RegistryPortLocation { get; set; }
    }
}