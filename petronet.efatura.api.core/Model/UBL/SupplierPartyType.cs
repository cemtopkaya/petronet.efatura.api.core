using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class SupplierPartyType {

        /// <remarks/>
        [XmlElement(Order = 0)]
        public PartyType Party { get; set; }

        /// <remarks/>
        [XmlElement(Order = 1)]
        public ContactType DespatchContact { get; set; }
    }
}
