using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TaxTotalType {
        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TaxAmountType TaxAmount { get; set; }

        /// <remarks/>
        [XmlElement("TaxSubtotal", Order = 1)]
        public TaxSubtotalType[] TaxSubtotal { get; set; }
    }
}
