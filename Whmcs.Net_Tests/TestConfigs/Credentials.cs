﻿using System;
namespace Whmcs.Net_Tests.TestConfigs
{
    public static class Credentials
    {
        public static string Username => GetEnvironmentValue("WhmcsUsername");

        public static string Password => GetEnvironmentValue("WhmcsPassword");

        public static string WhmcsApiUrl => GetEnvironmentValue("WhmcsApiUrl");

        private static string GetEnvironmentValue(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }
    }

    
}
