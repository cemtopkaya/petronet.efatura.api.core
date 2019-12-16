using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL {

    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class UBLExtensionType {

        [XmlElement(Order = 0)]
        public ExtensionContentType ExtensionContent { get; set; }
    }
}
