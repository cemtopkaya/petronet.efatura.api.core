using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class CodeType
    {        
        [XmlAttribute(DataType = "normalizedString")]
        public string listID { get; set; }

        
        [XmlAttribute(DataType = "normalizedString")]
        public string listAgencyID { get; set; }

        
        [XmlAttribute()]
        public string listAgencyName { get; set; }

        
        [XmlAttribute()]
        public string listName { get; set; }

        
        [XmlAttribute(DataType = "normalizedString")]
        public string listVersionID { get; set; }

        
        [XmlAttribute()]
        public string name { get; set; }

        
        [XmlAttribute(DataType = "language")]
        public string languageID { get; set; }

        
        [XmlAttribute(DataType = "anyURI")]
        public string listURI { get; set; }

        
        [XmlAttribute(DataType = "anyURI")]
        public string listSchemeURI { get; set; }

        
        [XmlText(DataType = "normalizedString")]
        public string Value { get; set; }
    }

}
