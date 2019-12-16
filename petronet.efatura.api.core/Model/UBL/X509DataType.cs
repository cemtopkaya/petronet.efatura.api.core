using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509DataType {

        [XmlAnyElement(Order = 0)]
        [XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType), Order = 0)]
        [XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [XmlElement("X509SubjectName", typeof(string), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore()]
        public ItemsChoiceType1[] ItemsElementName { get; set; }
    }
}