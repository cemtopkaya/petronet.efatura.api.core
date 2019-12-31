using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace petronet.efatura.api.core.Options {
    public class WCFServiceSettings {
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public T GetServiceProxy<T>(string url = null, string username = null, string password = null) {
            BasicHttpBinding basicHttpBinding = null;
            EndpointAddress endpointAddress = null;
            ChannelFactory<T> factory = null;

            basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;

            factory = new ChannelFactory<T>(basicHttpBinding, new EndpointAddress(new Uri(url ?? this.Address)));
            factory.Credentials.UserName.UserName = username ?? this.UserName;
            factory.Credentials.UserName.Password = password ?? this.Password;
            var serviceProxy = factory.CreateChannel();
            ((ICommunicationObject)serviceProxy).Open();

            return serviceProxy;
        }


        //private static IIntegration GetUyumsoftServiceProxy() {
        //    BasicHttpBinding basicHttpBinding = null;
        //    EndpointAddress endpointAddress = null;
        //    ChannelFactory<uyumsoft.IIntegration> factory = null;
        //    uyumsoft.IIntegration serviceProxy = null;

        //    //uyumsoft.IntegrationClient ic = GetUyumsoftClient(false);
        //    basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
        //    basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

        //    factory = new ChannelFactory<uyumsoft.IIntegration>(basicHttpBinding,
        //        new EndpointAddress(new Uri("https://efatura-test.uyumsoft.com.tr/Services/Integration")));
        //    factory.Credentials.UserName.UserName = "Uyumsoft";
        //    factory.Credentials.UserName.Password = "Uyumsoft";
        //    serviceProxy = factory.CreateChannel();
        //    ((ICommunicationObject)serviceProxy).Open();
        //    var opContext = new OperationContext((IClientChannel)serviceProxy);
        //    var prevOpContext = OperationContext.Current; // Optional if there's no way this might already be set
        //    OperationContext.Current = opContext;
        //    return serviceProxy;
        //}

        //private IntegrationClient GetUyumsoftClient(bool isProduction, int timeout) {
        //    var serviceAddress = isProduction
        //        ? "https://efatura.uyumsoft.com.tr/Services/Integration"
        //        : "https://efatura-test.uyumsoft.com.tr/Services/Integration";
        //    //: "http://efatura-test.uyumsoft.com.tr/services/BasicIntegration";


        //    var binding = new BasicHttpBinding() {
        //        MaxReceivedMessageSize = int.MaxValue,
        //        Security =
        //        {
        //            Transport = new HttpTransportSecurity() {
        //                ClientCredentialType = HttpClientCredentialType.None
        //            },
        //            Mode = BasicHttpSecurityMode.TransportWithMessageCredential
        //        },
        //    };

        //    var endPointTest = new EndpointAddress(serviceAddress);
        //    binding.CloseTimeout = TimeSpan.MaxValue;

        //    var client = new uyumsoft.IntegrationClient(binding, endPointTest);
        //    client.ClientCredentials.UserName.UserName = "Uyumsoft";
        //    client.ClientCredentials.UserName.Password = "Uyumsoft";
        //    return client;
        //}

    }
}
