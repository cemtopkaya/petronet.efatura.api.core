using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionContentType {

        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 0)]
        public SignatureType Signature { get; set; }
    }
}