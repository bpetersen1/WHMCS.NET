using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.net.Security;
using Whmcs.net.WhmcsServices;
using Whmcs.Net_Tests.TestConfigs;

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
           WhmcsServiceObject s = new WhmcsServiceObject(Credentials.WhmcsApiUrl, WhmcsActions.GetClients, Credentials.Username, Credentials.Password);
           // s.PostData.Add("search", "gphosting.co.za");
            string result = new WhmcsExecuteAction().ExecuteAction(s);
            Console.WriteLine(result);
            Assert.IsTrue(!string.IsNullOrEmpty(result));

        }
    }
}
