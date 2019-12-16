using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignedInfoType {

        [XmlElement(Order = 0)]
        public CanonicalizationMethodType CanonicalizationMethod { get; set; }

        [XmlElement(Order = 1)]
        public SignatureMethodType SignatureMethod { get; set; }

        [XmlElement("Reference", Order = 2)]
        public ReferenceType[] Reference { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}