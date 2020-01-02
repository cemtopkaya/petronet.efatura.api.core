using System.ServiceModel;

namespace petronet.efatura.api.core.Helper {


    public static class UyumsoftHelper{


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
        
        public static Uyumsoft.EFatura.IntegrationClient CreateServiceProxy(string serviceUrl, string userName, string password)
        {
            var basicHttpBinding = CreateBasicHttpBinding();
            var endPoint = new EndpointAddress(serviceUrl);

            var proxy = new Uyumsoft.EFatura.IntegrationClient(basicHttpBinding, endPoint);
            proxy.ClientCredentials.UserName.UserName = userName;
            proxy.ClientCredentials.UserName.Password = password;
            return proxy;
        }
    }
}
