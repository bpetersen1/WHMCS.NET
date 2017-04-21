using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            apidata.Add("password",pass);
            apidata.Add("responsetype", "json");
            string result = new WhmcsApi().CallWhmcsApi(data.WhmcsApiUrl, apidata);
            return result;
        }
    }
}
