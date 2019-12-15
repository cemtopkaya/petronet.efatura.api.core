using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType {

        [XmlEnum("##any:")]
        Item,

        PGPKeyID,

        PGPKeyPacket,
    }
}