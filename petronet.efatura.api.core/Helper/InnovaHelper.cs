using System.ServiceModel;
using InnovaEFaturaServis;

namespace petronet.efatura.api.core.Helper {

    public static class InnovaHelper {

        static BasicHttpBinding CreateBasicHttpBinding() {
            BasicHttpBinding basicHttpBinding = null;
            basicHttpBinding = new BasicHttpBinding(securityMode: BasicHttpSecurityMode.Transport);
            basicHttpBinding.AllowCookies = true;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            basicHttpBinding.MaxBufferSize = int.MaxValue;
            basicHttpBinding.MaxReceivedMessageSize = long.MaxValue;
            basicHttpBinding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            return basicHttpBinding;
        }

        public static ClientInterfaceServiceClient CreateServiceProxy(string url, string username, string password) {
            var basicHttpBinding = CreateBasicHttpBinding();
            var endpointAddress = new EndpointAddress(url);

            var client = new ClientInterfaceServiceClient(basicHttpBinding, endpointAddress);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;

            return client;
        }
    }
}
