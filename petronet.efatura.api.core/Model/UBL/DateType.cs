using System;
using System.Xml.Serialization;

namespace petronet.efatura.api.core.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class DateType
    {
        [XmlText(DataType = "date")]
        public DateTime Value { get; set; }
    }
}
