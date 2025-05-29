// CryptoService.cs
using System;
using System.Security.Cryptography;
using System.Text;

public static class CryptoService
{
    private static byte[] GenerateKey(string password)
    {
        using (SHA256 sha = SHA256.Create())
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public static string Encrypt(string plainText, string password)
    {
        byte[] key = GenerateKey(password);
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.GenerateIV();
            using (ICryptoTransform encryptor = aes.CreateEncryptor())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                byte[] result = new byte[aes.IV.Length + encrypted.Length];
                Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
                Buffer.BlockCopy(encrypted, 0, result, aes.IV.Length, encrypted.Length);

                return Convert.ToBase64String(result);
            }
        }
    }

    public static string Decrypt(string encryptedText, string password)
    {
        byte[] fullCipher = Convert.FromBase64String(encryptedText);
        byte[] key = GenerateKey(password);
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            byte[] iv = new byte[aes.BlockSize / 8];
            byte[] cipher = new byte[fullCipher.Length - iv.Length];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, cipher.Length);

            aes.IV = iv;

            using (ICryptoTransform decryptor = aes.CreateDecryptor())
            {
                byte[] decryptedBytes = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
