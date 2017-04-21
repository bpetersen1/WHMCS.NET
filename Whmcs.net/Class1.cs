using Whmcs.net.WhmcsServices;

namespace Whmcs.net
{
    public class Class1
    {
        public void t()
        {
            WhmcsServiceObject s = new WhmcsServiceObject("http://www.whmcs.com/api.php", WhmcsActions.GetClients,"username","password");

            s.PostData.Add("key","Data");
            s.PostData.Add("key", "Data");
            s.PostData.Add("key", "Data");

        }


    }
}
