using System;
using System.Text;

namespace DataProtectionApp
{
    public class Encryptor
    {
        private readonly string key;

        public Encryptor(string key)
        {
            this.key = key;
        }

        public string Encrypt(string plainText)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < plainText.Length; i++)
            {
                char encryptedChar = (char)(plainText[i] ^ key[i % key.Length]);
                result.Append(encryptedChar);
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(result.ToString()));
        }

        public string Decrypt(string cipherText)
        {
            string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(cipherText));
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < decoded.Length; i++)
            {
                char decryptedChar = (char)(decoded[i] ^ key[i % key.Length]);
                result.Append(decryptedChar);
            }
            return result.ToString();
        }
    }
}