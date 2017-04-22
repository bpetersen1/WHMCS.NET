using System.Collections.Specialized;
namespace Whmcs.net.WhmcsServices
{
    public class WhmcsServiceObject
    {
        public WhmcsServiceObject(string whmcsApiUrl,string action,string userName, string password)
        {
            PostData = new NameValueCollection();
            Action = action;
            Username = userName;
            WhmcsApiUrl = whmcsApiUrl;
            Password = password;
        }

        public WhmcsServiceObject(string whmcsApiUrl, string action, string userName, string password,string accessKey)
        {
            PostData = new NameValueCollection();
            Action = action;
            Username = userName;
            WhmcsApiUrl = whmcsApiUrl;
            Password = password;
            AccessKey = accessKey;
        }

        public string Action { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public string WhmcsApiUrl { get; private set; }

        public string AccessKey { get; private set; }

        public NameValueCollection PostData { get; set; }

    }
}
