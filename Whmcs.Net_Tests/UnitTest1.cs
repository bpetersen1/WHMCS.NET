using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.net;
using Whmcs.net.Security;
using Whmcs.net.WhmcsServices;

namespace Whmcs.Net_Tests
{
    [TestClass]
    public class SecurityTest
    {
        [TestMethod]
        public void Test_Generate_MD5_Hashed_Password()
        {
            Password pass = new Password();
            string result = pass.HashPassword("yoyoyoyoHappyDays");
            Console.WriteLine($"The result of the Password hash is : {result}");
            Assert.IsTrue(!string.IsNullOrEmpty(result),result);
        }

        [TestMethod]
        public void Test_GetClients()
        {
            WhmcsServiceObject s = new WhmcsServiceObject("https://www.whmcssite.co.za/includes/api.php", WhmcsActions.GetInvoices, "username", "password");
            s.PostData.Add("userid", "5");
            string result = new WhmcsExecuteAction().ExecuteAction(s);
            Assert.IsTrue(!string.IsNullOrEmpty(result));

        }
    }
}
