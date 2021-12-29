using System;
using System.Security.Cryptography;
using System.Text;

namespace ProvHash
{
    internal static class HashUtilities
    {
        public static string HashBytesToString(byte[] bts)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in bts)
                stringBuilder.AppendFormat("{0:x2}", b);

            return stringBuilder.ToString();
        }

        public static string HashString(string src)
        {
            var data = SHA256.HashData(Encoding.UTF8.GetBytes(src));
            return HashBytesToString(data);
        }
    }
}
