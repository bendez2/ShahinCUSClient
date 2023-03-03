using System;
using System.Security.Cryptography;
using System.Text;

namespace Nastol
{
    public class HashingString
    {
        public static string HashingPassword(string password)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashingPass = BitConverter.ToString(hash).Replace("-", "");
            var sha256 = new SHA256Managed();
            hashingPass = BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(hashingPass))).Replace("-", "");

            return hashingPass;
        }
    }
}
