using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyInfoType {

        [XmlAnyElement(Order = 0)]
        [XmlElement("KeyName", typeof(string), Order = 0)]
        [XmlElement("KeyValue", typeof(KeyValueType), Order = 0)]
        [XmlElement("MgmtData", typeof(string), Order = 0)]
        [XmlElement("PGPData", typeof(PGPDataType), Order = 0)]
        [XmlElement("RetrievalMethod", typeof(RetrievalMethodType), Order = 0)]
        [XmlElement("SPKIData", typeof(SPKIDataType), Order = 0)]
        [XmlElement("X509Data", typeof(X509DataType), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
        public enum ItemsChoiceType2 {

            [XmlEnum("##any:")]
            Item,

            KeyName,

            KeyValue,

            MgmtData,

            PGPData,

            RetrievalMethod,

            SPKIData,

            X509Data,
        }


        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore()]
        public ItemsChoiceType2[] ItemsElementName { get; set; }

        [XmlText()]
        public string[] Text { get; set; }

        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}