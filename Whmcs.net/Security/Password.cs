using System;
using System.Security.Cryptography;
using System.Text;

namespace Whmcs.net.Security
{
    public class Password
    {
        public string HashPassword(string password)
        {
            string hashedPassword;
            using (MD5 md5 = MD5.Create())
            {
                byte[] utfencodedPassword = UtfEncodePassword(password);
                hashedPassword = BitConverter.ToString(md5.ComputeHash(utfencodedPassword)).Replace("-",string.Empty);
            }
            return hashedPassword;
        }

        private byte[] UtfEncodePassword(string password)
        {
            return Encoding.UTF8.GetBytes(password);
        }
    }
}
