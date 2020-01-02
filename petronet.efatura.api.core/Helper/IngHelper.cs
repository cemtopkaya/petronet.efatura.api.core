using System.ServiceModel;
using ING.EFatura;

namespace petronet.efatura.api.core.Helper {


    public static class IngHelper {


        static BasicHttpBinding CreateBasicHttpBinding() {
            BasicHttpBinding basicHttpBinding = null;
            basicHttpBinding = new BasicHttpBinding(securityMode: BasicHttpSecurityMode.Transport);
            //basicHttpBinding.AllowCookies = true;
            //basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            basicHttpBinding.MaxBufferSize = int.MaxValue;
            basicHttpBinding.MaxReceivedMessageSize = long.MaxValue;
            basicHttpBinding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            return basicHttpBinding;
        }

        public static ClientEInvoiceServicesPortClient CreateServiceProxy(string serviceUrl, string userName, string password)
        {
            var basicHttpBinding = CreateBasicHttpBinding();
            var endPoint = new EndpointAddress(serviceUrl);

            var proxy = new ClientEInvoiceServicesPortClient(basicHttpBinding, endPoint);
            proxy.ClientCredentials.UserName.UserName = userName;
            proxy.ClientCredentials.UserName.Password = password;
            return proxy;
        }
    }
}
