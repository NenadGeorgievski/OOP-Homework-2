using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    static class EncrypterClass
    {
        static readonly char[] alphabet = { 'z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static string Encrypt(string someString)
        {
            char[] chars = someString.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int charPosition = Array.IndexOf(alphabet, chars[i]);
                chars[i] = alphabet[charPosition + 1];
                
            }
            string changedString = new string(chars);
            return changedString;

        }

        public static string Decrypt(string someString)
        {
            char[] chars = someString.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int charPosition = Array.IndexOf(alphabet, chars[i]);
                chars[i] = alphabet[charPosition - 1];

            }
            string changedString = new string(chars);
            return changedString;
        }
    }
}
