using System;
using Whmcs.net.WhmcsServices;

namespace Whmcs.net
{
    public static class Api
    {
        public static string GetClients(int? limitstart, int? limitnum, string search = "")
        {
            WhmcsServiceObject s = new WhmcsServiceObject(Environment.GetEnvironmentVariable("WhmcsApiUrl"), WhmcsActions.GetClients, "website_user", "Gphosting659");
            if(limitstart!= null) s.PostData.Add("limitstart",limitstart.ToString());
            if (limitnum != null) s.PostData.Add("limitnum", limitnum.ToString());
            if (search != null) s.PostData.Add("search", search);
            string result = new WhmcsExecuteAction().ExecuteAction(s);

            return result;
        }


    }
}
