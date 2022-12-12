using System;
using System.Security.Cryptography;
using System.Text;

namespace FN.Store.Domain._2.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string senha)
        {
            var salt = "|4CAD39F5B2EB4099B0309AFFF2191D3AD800484B0394400B8515265AA5395B45";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }



            return Convert.ToBase64String(hashBytes);
        }
    }
}
