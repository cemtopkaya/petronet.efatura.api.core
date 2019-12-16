using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class DocumentReferenceType {

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public IssueDateType IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public DocumentTypeCodeType DocumentTypeCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DocumentTypeType DocumentType { get; set; }

        [XmlElement("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public DocumentDescriptionType[] DocumentDescription { get; set; }

        [XmlElement(Order = 5)]
        public AttachmentType Attachment { get; set; }

        [XmlElement(Order = 6)]
        public PeriodType ValidityPeriod { get; set; }

        [XmlElement(Order = 7)]
        public PartyType IssuerParty { get; set; }
    }

}
