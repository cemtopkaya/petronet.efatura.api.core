using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509IssuerSerialType {

        [XmlElement(Order = 0)]
        public string X509IssuerName { get; set; }

        [XmlElement(DataType = "integer", Order = 1)]
        public string X509SerialNumber { get; set; }
    }
}