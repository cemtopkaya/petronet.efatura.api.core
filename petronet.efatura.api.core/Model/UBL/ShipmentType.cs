using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ShipmentType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public HandlingCodeType HandlingCode { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HandlingInstructionsType HandlingInstructions { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public GrossWeightMeasureType GrossWeightMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public NetWeightMeasureType NetWeightMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public GrossVolumeMeasureType GrossVolumeMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public NetVolumeMeasureType NetVolumeMeasure { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public InsuranceValueAmountType InsuranceValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }


        [XmlElement("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        public SpecialInstructionsType[] SpecialInstructions { get; set; }


        [XmlElement("GoodsItem", Order = 15)]
        public GoodsItemType[] GoodsItem { get; set; }


        [XmlElement("ShipmentStage", Order = 16)]
        public ShipmentStageType[] ShipmentStage { get; set; }


        [XmlElement(Order = 17)]
        public DeliveryType Delivery { get; set; }


        [XmlElement("TransportHandlingUnit", Order = 18)]
        public TransportHandlingUnitType[] TransportHandlingUnit { get; set; }


        [XmlElement(Order = 19)]
        public AddressType ReturnAddress { get; set; }


        [XmlElement(Order = 20)]
        public LocationType1 FirstArrivalPortLocation { get; set; }


        [XmlElement(Order = 21)]
        public LocationType1 LastExitPortLocation { get; set; }
    }
}