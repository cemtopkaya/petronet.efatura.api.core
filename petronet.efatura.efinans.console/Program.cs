using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using uyumsoftServis;

namespace petronet.efatura.efinans.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            XmlSerializer ser = new XmlSerializer(typeof(api.core.Model.UBL.InvoiceType));
            var ms = new MemoryStream();

            //ser.Serialize(ms,new api.core.Model.UBL.InvoiceType()
            //{
            //    ID = new api.core.Model.UBL.IDType() { Value = "Hede"}
            //});
            //var s = Encoding.ASCII.GetString(ms.ToArray());
            string bas = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<Invoice xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"" 
xmlns:qdt=""urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"" 
xmlns:cctc=""urn:un:unece:uncefact:documentation:2"" 
xmlns:ubltr=""urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents"" 
xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
xmlns:udt=""urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"" 
xmlns:cac=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" 
xmlns:ext=""urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"" 
xmlns:cbc=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" 
xmlns:xades=""http://uri.etsi.org/01903/v1.3.2#"" 
xsi:schemaLocation=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBL-Invoice-2.1.xsd"" 
 xmlns=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2""
></Invoice>";
            /*
 xmlns=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2""
             */
            //XmlReader xr = new XmlTextReader(new MemoryStream(Encoding.ASCII.GetBytes(bas)));
            //var a1 = ser.Deserialize(xr);

            var obj = ser.Deserialize(File.OpenRead(@"C:\Users\cemt\Downloads\9b9d0c93-5e18-4b65-88e9-39e47cf6e651.xml"));

            var client = new HttpClient();
            //InvoiceClient ic = new InvoiceClient(client);
            // TestInvoiceClient tic = new TestInvoiceClient(client);
            uyumsoftServis.IntegrationClient ic = new IntegrationClient(null, null);
            ic.SaveAsDraftAsync(new[]
            {
                new InvoiceInfo()
                {
                    EArchiveInvoiceInfo = new EArchiveInvoiceInformation()
                    {

                    }
                }
            });

            var ii = new uyumsoftServis.InvoiceInfo {
                Invoice = new uyumsoftServis.InvoiceType {
                   // AdditionalDocumentReference = new uyumsoftServis.DocumentReferenceType
                }
            };

        }
    }
}
