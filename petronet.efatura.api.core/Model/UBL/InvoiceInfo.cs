using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://tempuri.org/")]
    public class InvoiceInfo {
        private XmlSerializerNamespaces xmlns;

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns {
            get {
                if (xmlns == null)
                {
                    xmlns = new XmlSerializerNamespaces();
                    xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                }
                return xmlns;
            }
            set { xmlns = value; }
        }
        public InvoiceType Invoice { get; set; }
    }
}
