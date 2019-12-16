using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class PGPDataType {

        [XmlAnyElement(Order = 0)]
        [XmlElement("PGPKeyID", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [XmlElement("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary", Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName { get; set; }
    }
}