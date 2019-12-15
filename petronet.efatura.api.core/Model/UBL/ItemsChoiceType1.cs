using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType1 {

        [XmlEnum("##any:")]
        Item,

        X509CRL,

        X509Certificate,

        X509IssuerSerial,

        X509SKI,

        X509SubjectName,
    }
}