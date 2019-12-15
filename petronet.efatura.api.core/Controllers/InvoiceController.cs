using System;
using Microsoft.AspNetCore.Mvc;
using UBL = petronet.efatura.api.core.Model.UBL;
using petronet.efatura.api.core.Model.Response;
//using uyumsoft;

namespace petronet.efatura.api.core.Controllers {

    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase {
        [HttpGet]
        [DisableRequestSizeLimit]
        [Produces("application/xml")]
        public IActionResult Get() {
            var ii = new UBL.InvoiceInfo {
                Invoice = new UBL.InvoiceType {
                    ID = new UBL.IDType {
                        schemeID = "VKN",
                        Value = "123123"
                    },
                    ProfileID = new UBL.ProfileIDType { Value = "TICARIFATURA" },
                    UBLVersionID = new UBL.UBLVersionIDType { Value = "2.1" },
                    CustomizationID = new UBL.CustomizationIDType { Value = "TR1.2" },
                    IssueDate = new UBL.IssueDateType { Value = DateTime.Parse("2009-01-05") },
                    IssueTime = new UBL.IssueTimeType { Value = DateTime.Parse("14:42:00") },
                    InvoiceTypeCode = new UBL.InvoiceTypeCodeType { Value = "SATIS" },
                    Note = new[]
                    {
                        new UBL.NoteType {Value = "notum not olsun 1"},
                        new UBL.NoteType {Value = "notum not olsun 2"}
                    },
                    DocumentCurrencyCode = new UBL.DocumentCurrencyCodeType { Value = "TRY" },
                    LineCountNumeric = new UBL.LineCountNumericType() { Value = 2 },
                    AdditionalDocumentReference = new[]
                    {
                        new UBL.DocumentReferenceType
                        {
                            ID = new UBL.IDType {Value = "703a3cda-be8d-4964-bfa2-29b63c14e712"},
                            IssueDate = new UBL.IssueDateType {Value = DateTime.Now},
                            DocumentType = new UBL.DocumentTypeType {Value = "Xslt"}
                        },
                    },
                    Signature = new[]
                    {
                        new UBL.SignatureType1
                        {
                            ID = new UBL.IDType()
                            {
                                schemeID = "VKN",
                                Value = "9000068418"
                            }
                        }
                    },
                    AccountingSupplierParty = new UBL.SupplierPartyType {
                        Party = new UBL.PartyType {
                            WebsiteURI = new UBL.WebsiteURIType { Value = "www.ulukom.com.tr" },
                            PartyIdentification = new[]
                            {
                                new UBL.PartyIdentificationType
                                {
                                    ID = new UBL.IDType {schemeID = "VKN", Value = "9000068418"}
                                },
                                new UBL.PartyIdentificationType
                                {
                                    ID = new UBL.IDType {schemeID = "TICARETSICILNO", Value = "999999"}
                                },
                                new UBL.PartyIdentificationType
                                {
                                    ID = new UBL.IDType {schemeID = "MERSISNO", Value = "125363"}
                                }
                            },
                            PartyName = new UBL.PartyNameType {
                                Name = new UBL.NameType1 {
                                    Value = "TST_ULUKOM BİLGİSAYAR YAZILIM DONANIM DAN.SAN.VE TİC. LTD.ŞTİ."
                                }
                            },
                            PostalAddress = new UBL.AddressType {
                                StreetName = new UBL.StreetNameType { Value = "1.TAŞOCAĞI CD. BU.... M.KÖY" },
                                CitySubdivisionName = new UBL.CitySubdivisionNameType { Value = "Maslak" },
                                CityName = new UBL.CityNameType { Value = "İstanbul" },
                                Country = new UBL.CountryType {
                                    Name = new UBL.NameType1 { Value = "Türkiye" }
                                }
                            },
                            PartyTaxScheme = new UBL.PartyTaxSchemeType {
                                TaxScheme = new UBL.TaxSchemeType { Name = new UBL.NameType1 { Value = "BEYKOZ" } }
                            },
                            Contact = new UBL.ContactType {
                                Telephone = new UBL.TelephoneType { Value = "0 212 212 26 92" },
                                Telefax = new UBL.TelefaxType { Value = "0 212 212 26 67" },
                                ElectronicMail = new UBL.ElectronicMailType { Value = "ulukom@ulukom.com.tr" },
                            }
                        },
                    },
                    AccountingCustomerParty = new UBL.CustomerPartyType {
                        Party = new UBL.PartyType {
                            WebsiteURI = new UBL.WebsiteURIType {
                                Value = "www.ulukom.com.tr"
                            },
                            PartyIdentification = new[]
                            {
                                new UBL.PartyIdentificationType
                                {
                                    ID = new UBL.IDType
                                    {
                                        schemeID = "VKN",
                                        Value = "9000068418"
                                    }
                                }
                            },
                            PartyName = new UBL.PartyNameType {
                                Name = new UBL.NameType1 {
                                    Value = "ULUKOM  LOGISTICS"
                                }
                            },
                            PostalAddress = new UBL.AddressType {
                                StreetName = new UBL.StreetNameType { Value = "1.TAŞOCAĞI CD. BU.... M.KÖY" },
                                CitySubdivisionName = new UBL.CitySubdivisionNameType { Value = "Maslak" },
                                CityName = new UBL.CityNameType { Value = "İstanbul" },
                                Country = new UBL.CountryType {
                                    Name = new UBL.NameType1 { Value = "Türkiye" }
                                }
                            },
                            PartyTaxScheme = new UBL.PartyTaxSchemeType {
                                TaxScheme = new UBL.TaxSchemeType { Name = new UBL.NameType1 { Value = "BEYKOZ" } }
                            },
                            Contact = new UBL.ContactType {
                                Telephone = new UBL.TelephoneType { Value = "0 212 212 26 92" },
                                Telefax = new UBL.TelefaxType { Value = "0 212 212 26 67" },
                                ElectronicMail = new UBL.ElectronicMailType { Value = "ulukom@ulukom.com.tr" },
                            }
                        }
                    },
                    TaxTotal = new[]
                    {
                        new UBL.TaxTotalType()
                        {
                            TaxAmount = new UBL.TaxAmountType() {Value = 900, currencyID = "TRY"},
                            TaxSubtotal = new[]
                            {
                                new UBL.TaxSubtotalType()
                                {
                                    TaxableAmount = new UBL.TaxableAmountType() {currencyID = "TRY", Value = 5000},
                                    Percent = new UBL.PercentType1() {Value = 18},
                                    TaxCategory = new UBL.TaxCategoryType()
                                    {
                                        TaxScheme = new UBL.TaxSchemeType()
                                        {
                                            Name = new UBL.NameType1() {Value = "KDV"},
                                            TaxTypeCode = new UBL.TaxTypeCodeType() {Value = "015"}
                                        }
                                    }
                                }
                            }
                        },
                        new UBL.TaxTotalType()
                        {
                            TaxAmount = new UBL.TaxAmountType() {Value = 160, currencyID = "TRY"},
                            TaxSubtotal = new[]
                            {
                                new UBL.TaxSubtotalType()
                                {
                                    TaxableAmount = new UBL.TaxableAmountType() {currencyID = "TRY", Value = 2000},
                                    Percent = new UBL.PercentType1() {Value = 8},
                                    TaxCategory = new UBL.TaxCategoryType()
                                    {
                                        TaxScheme = new UBL.TaxSchemeType()
                                        {
                                            Name = new UBL.NameType1() {Value = "KDV"},
                                            TaxTypeCode = new UBL.TaxTypeCodeType() {Value = "015"}
                                        }
                                    }
                                }
                            }
                        }
                    },
                    LegalMonetaryTotal = new UBL.MonetaryTotalType() {
                        LineExtensionAmount = new UBL.LineExtensionAmountType() { Value = 7000, currencyID = "TRY" },
                        TaxExclusiveAmount = new UBL.TaxExclusiveAmountType() { Value = 7000, currencyID = "TRY" },
                        TaxInclusiveAmount = new UBL.TaxInclusiveAmountType() { Value = 1060, currencyID = "TRY" },
                        AllowanceTotalAmount = new UBL.AllowanceTotalAmountType() { Value = 0, currencyID = "TRY" },
                        PayableAmount = new UBL.PayableAmountType() { Value = 8060, currencyID = "TRY" }
                    },
                    InvoiceLine = new[]
                    {
                        new UBL.InvoiceLineType()
                        {
                            ID = new UBL.IDType(){Value = "1"},
                            Note = new []{ new UBL.NoteType(){Value = "WAREHOUSE HANDLING COSTS ACTUAL" } },
                            InvoicedQuantity = new UBL.InvoicedQuantityType(){Value =1,unitCode = "NIU"},
                            LineExtensionAmount = new UBL.LineExtensionAmountType(){Value = 5000,currencyID = "TRY"},
                            TaxTotal = new UBL.TaxTotalType()
                            {
                                TaxAmount = new UBL.TaxAmountType(){Value = 900, currencyID = "TRY"},
                                TaxSubtotal = new []
                                {
                                    new UBL.TaxSubtotalType()
                                    {
                                        TaxableAmount = new UBL.TaxableAmountType(){Value = 5000, currencyID = "TRY"},
                                        TaxAmount = new UBL.TaxAmountType(){ Value = 900, currencyID = "TRY"},
                                        Percent = new UBL.PercentType1(){Value = 18},
                                        TaxCategory = new UBL.TaxCategoryType()
                                        {
                                            TaxExemptionReason = new UBL.TaxExemptionReasonType(),
                                            TaxScheme = new UBL.TaxSchemeType()
                                            {
                                                Name =  new UBL.NameType1(){ Value = "KDV"},
                                                TaxTypeCode = new UBL.TaxTypeCodeType(){Value = "015"}
                                            }
                                        }
                                    }
                                }
                            },
                            Item = new UBL.ItemType()
                            {
                                Description = new UBL.DescriptionType(){Value = "WAREHOUSE HANDLING COSTS ACTUAL"},
                                Name = new UBL.NameType1(){Value = "WAREHOUSE HANDLING COSTS ACTUAL"},
                                BrandName = new UBL.BrandNameType(){Value = "WAREHOUSE HANDLING COSTS ACTUAL"},
                                ModelName = new UBL.ModelNameType(){Value = "WAREHOUSE HANDLING COSTS ACTUAL"},
                                SellersItemIdentification = new UBL.ItemIdentificationType()
                                {
                                    ID = new UBL.IDType(){Value = "1210.20.10"},
                                }
                            },
                            Price = new UBL.PriceType()
                            {
                                PriceAmount = new UBL.PriceAmountType()
                                {
                                    Value = 5000,
                                    currencyID = "TRY"
                                }
                            }
                        }
                    }
                }
            };

            return Ok(ii);
        }

        [HttpPost]
        public SingleResponse<UBL.InvoiceInfo> Post([FromBody] UBL.InvoiceInfo invoice) {
            return new SingleResponse<UBL.InvoiceInfo>() {
                Model = invoice
            };
        }
    }
}