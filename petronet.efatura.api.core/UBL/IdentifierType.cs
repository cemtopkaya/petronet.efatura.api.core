using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace petronet.efatura.api.core.UBL
{

    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class IdentifierType
    {
        [XmlAttribute(DataType = "normalizedString")]
        public string schemeID { get; set; }

        [XmlAttribute()]
        public string schemeName { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string schemeAgencyID { get; set; }

        [XmlAttribute()]
        public string schemeAgencyName { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string schemeVersionID { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string schemeDataURI { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string schemeURI { get; set; }

        [XmlTextAttribute(DataType = "normalizedString")]
        public string Value { get; set; }
    }
}
