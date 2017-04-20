using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whmcs.net;
using Whmcs.net.Security;

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
    }
}
