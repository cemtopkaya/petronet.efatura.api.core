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
                    Note = new[] {
                        new UBL.NoteType { Value = "notum not olsun 1" },
                        new UBL.NoteType { Value = "notum not olsun 2" }
                    },
                    DocumentCurrencyCode = new UBL.DocumentCurrencyCodeType { Value = "TRY" },
                    LineCountNumeric = new UBL.LineCountNumericType() { Value = 2 },
                    AdditionalDocumentReference = new[]{
                        new UBL.DocumentReferenceType {
                            ID = new UBL.IDType { Value = "703a3cda-be8d-4964-bfa2-29b63c14e712" },
                            IssueDate = new UBL.IssueDateType{ Value= DateTime.Now },
                            DocumentType = new UBL.DocumentTypeType { Value = "Xslt" }
                        },
                    },
                    Signature = new[]{
                        new UBL.SignatureType1 {
                            ID = new UBL.IDType() {
                                schemeID = "VKN",
                                Value = "9000068418"
                            }
                        }
                    },
                    AccountingSupplierParty = new UBL.SupplierPartyType {
                        Party = new UBL.PartyType {
                            WebsiteURI = new UBL.WebsiteURIType { Value = "www.ulukom.com.tr" },
                            PartyIdentification = new[] {
                                new UBL.PartyIdentificationType {
                                    ID = new UBL.IDType { schemeID="VKN", Value = "9000068418" }
                                },
                                new UBL.PartyIdentificationType {
                                    ID = new UBL.IDType { schemeID="TICARETSICILNO", Value = "999999" }
                                },
                                new UBL.PartyIdentificationType {
                                    ID = new UBL.IDType { schemeID="MERSISNO", Value = "125363" }
                                }
                            },
                            PartyName = new UBL.PartyNameType { 
                                Name = new UBL.NameType1 { 
                                    Value = "TST_ULUKOM BİLGİSAYAR YAZILIM DONANIM DAN.SAN.VE TİC. LTD.ŞTİ." 
                                } 
                            },
                            PostalAddress = new UBL.AddressType {
                                StreetName = new UBL.StreetNameType { Value= "1.TAŞOCAĞI CD. BU.... M.KÖY" },
                                CitySubdivisionName = new UBL.CitySubdivisionNameType { Value="Maslak" },
                                CityName = new UBL.CityNameType { Value = "İstanbul" },
                                Country = new UBL.CountryType {
                                    Name = new UBL.NameType1 { Value = "Türkiye" }
                                }
                            },
                            PartyTaxScheme = new UBL.PartyTaxSchemeType {
                                TaxScheme = new UBL.TaxSchemeType { Name = new UBL.NameType1 { Value="BEYKOZ" } }
                            },
                            Contact = new UBL.ContactType { 
                                Telephone =new UBL.TelephoneType {Value = "0 212 212 26 92" },
                                Telefax = new UBL.TelefaxType { Value = "0 212 212 26 67" },
                                ElectronicMail = new UBL.ElectronicMailType { Value = "ulukom@ulukom.com.tr" },
                            }
                        },

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