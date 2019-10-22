using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace petronet.efatura.api.core.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IDType : IdentifierType1
    {
    }
}
