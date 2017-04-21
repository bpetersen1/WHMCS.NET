using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

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

        public string Action { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public string WhmcsApiUrl { get; private set; }

        public NameValueCollection PostData { get; set; }

    }
}
