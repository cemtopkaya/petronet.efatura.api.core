using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class LocationType1 {

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement(Order = 1)]
        public AddressType Address { get; set; }
    }
}
