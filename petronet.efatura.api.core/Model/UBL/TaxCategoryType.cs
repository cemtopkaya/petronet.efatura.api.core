using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TaxCategoryType {
        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NameType1 Name { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TaxExemptionReasonCodeType TaxExemptionReasonCode { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TaxExemptionReasonType TaxExemptionReason { get; set; }

        /// <remarks/>
        [XmlElement(Order = 3)]
        public TaxSchemeType TaxScheme { get; set; }
    }
}
