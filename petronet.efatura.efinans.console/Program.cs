using System;
using System.Net.Http;

namespace petronet.efatura.efinans.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new HttpClient();
            //InvoiceClient ic = new InvoiceClient(client);
            //TestInvoiceClient tic = new TestInvoiceClient(client);


            var ii = new uyumsoftServis.InvoiceInfo {
                Invoice = new uyumsoftServis.InvoiceType {
                   // AdditionalDocumentReference = new uyumsoftServis.DocumentReferenceType
                }
            };

        }
    }
}
