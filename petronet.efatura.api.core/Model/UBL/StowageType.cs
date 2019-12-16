using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class StowageType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public LocationIDType LocationID { get; set; }


        [XmlElement("Location", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public LocationType[] Location { get; set; }


        [XmlElement("MeasurementDimension", Order = 2)]
        public DimensionType[] MeasurementDimension { get; set; }
    }
}