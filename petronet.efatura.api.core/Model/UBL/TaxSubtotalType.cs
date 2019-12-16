using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TaxSubtotalType {

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TaxableAmountType TaxableAmount { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TaxAmountType TaxAmount { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public CalculationSequenceNumericType CalculationSequenceNumeric { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public PercentType1 Percent { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public BaseUnitMeasureType BaseUnitMeasure { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public PerUnitAmountType PerUnitAmount { get; set; }

        /// <remarks/>
        [XmlElement(Order = 7)]
        public TaxCategoryType TaxCategory { get; set; }
    }

}
