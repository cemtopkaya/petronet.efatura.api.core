using System.Xml.Serialization;

namespace petronet.efatura.api.core.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class TimeType
    {
        [XmlText(DataType = "time")]
        public System.DateTime Value { get; set; }
    }
}
