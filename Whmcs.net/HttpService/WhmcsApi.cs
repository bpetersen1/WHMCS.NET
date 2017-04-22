using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace Whmcs.net.HttpService
{
    internal class WhmcsApi
    {
        public string CallWhmcsApi(string url,NameValueCollection postData)
        {
            using (WebClient client = new WebClient())
            {
                
                byte[] response =
                    client.UploadValues(url, postData);

                return Encoding.UTF8.GetString(response);
            }
        }
    }
}
