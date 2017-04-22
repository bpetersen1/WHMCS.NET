using System.Collections.Specialized;
using Whmcs.net.HttpService;

namespace Whmcs.net.WhmcsServices
{
    public class WhmcsExecuteAction
    {
        public string ExecuteAction(WhmcsServiceObject data)
        {
            string pass = new Security.Password().HashPassword(data.Password);
            NameValueCollection apidata = data.PostData;
            apidata.Add("action",data.Action);
            apidata.Add("username",data.Username);
            apidata.Add("password", pass);
            apidata.Add("responsetype", "json");
            if(!string.IsNullOrEmpty(data.AccessKey)) apidata.Add("accesskey", data.AccessKey);
            string result = new WhmcsApi().CallWhmcsApi(data.WhmcsApiUrl, apidata);
            return result;
        }
    }
}
