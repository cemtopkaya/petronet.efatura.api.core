﻿using System.Xml.Serialization;

namespace petronet.efatura.api.core.Model.UBL
{
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PriceType {


        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public PriceAmountType PriceAmount { get; set; }
    }
}