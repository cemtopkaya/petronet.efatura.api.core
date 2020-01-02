using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using EFinans.EFatura.ConnectorService;
using EFinans.EFatura.UserService;

namespace petronet.efatura.api.core.Helper {
    public class SessionInfo {
        const double EFINANS_DEFAULT_COOKIE_EXPIRATION = 30;
        public string Key, Cookie;
        public DateTime ExpirationTime;

        public SessionInfo(string key, string cookie, DateTime? expirationTime = null) {
            Key = key;
            Cookie = cookie;
            ExpirationTime = expirationTime ?? DateTime.Now.AddMinutes(EFINANS_DEFAULT_COOKIE_EXPIRATION);
        }
    }


    public static class EFinansHelper{


        static Dictionary<string, SessionInfo> _sessionsDictionary;
        static Dictionary<string, SessionInfo> _sessions {
            get {
                return _sessionsDictionary ?? (_sessionsDictionary = new Dictionary<string, SessionInfo>());
            }
        }


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

        public static ConnectorServiceClient CreateConnectorServiceClient(string url, string username, string password) {
            var basicHttpBinding = CreateBasicHttpBinding();
            var endpointAddress = new EndpointAddress(url);
            var client = new ConnectorServiceClient(basicHttpBinding, endpointAddress);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;

            return client;
        }

        public static UserServiceClient CreateUserServiceClient(string url, string username, string password) {
            var basicHttpBinding = CreateBasicHttpBinding();
            var endpointAddress = new EndpointAddress(url);

            var client = new UserServiceClient(basicHttpBinding, endpointAddress);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }

        public static string GetValidCookie(UserServiceClient userWsClient, string userName, string password) {
            var cookie = string.Empty;
            var cookieKey = $"{userName}_{password}";

            bool isCookieExistAndValid = _sessions.ContainsKey(cookieKey) && _sessions[cookieKey].ExpirationTime > DateTime.Now;
            cookie = isCookieExistAndValid ? _sessions[cookieKey].Cookie : GetCookieFromEFinans(userWsClient, userName, password);
            return cookie;
        }

        static string GetCookieFromEFinans(UserServiceClient userWsClient, string userName, string password) {
            string cookie;
            using (var scopeUser = new OperationContextScope(userWsClient.InnerChannel)) {
                userWsClient.wsLogin(userName, password, "tr");
                var httpProperties = (HttpResponseMessageProperty)OperationContext.Current.IncomingMessageProperties[HttpResponseMessageProperty.Name];
                var headers = httpProperties.Headers;
                cookie = httpProperties.Headers["Set-Cookie"];
            }

            return cookie;
        }
    }
}
