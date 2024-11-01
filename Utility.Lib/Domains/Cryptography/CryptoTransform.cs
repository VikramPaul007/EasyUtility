using System;
using System.Security.Cryptography;
using System.Text;

namespace Utility.Lib.Domains.Cryptography
{
    public class CryptoTransform : ICrypto
    {
        private readonly byte[] _key;
        private readonly byte[] _iv;

        public CryptoTransform(string secretKey)
        {
            _key = Encoding.UTF8.GetBytes(secretKey);
            _iv = new byte[16];
            new Random().NextBytes(_iv);
        }
        public string Decrypt(string cipherText)
        {
            byte[] cipherBytes = Encoding.UTF8.GetBytes(cipherText);

            using Aes aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            // Encrypt the input plaintext using the AES algorithm
            using ICryptoTransform decryptor = aes.CreateDecryptor();
            byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

            return Convert.ToBase64String(decryptedBytes);
        }

        public string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using Aes aes = Aes.Create();
            aes.Key = _key;
            aes.IV = _iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            // Encrypt the input plaintext using the AES algorithm
            using ICryptoTransform encryptor = aes.CreateEncryptor();
            byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

            return Convert.ToBase64String(encryptedBytes);
        }
    }
}
