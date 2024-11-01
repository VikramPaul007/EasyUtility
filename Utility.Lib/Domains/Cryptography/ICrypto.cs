namespace Utility.Lib.Domains.Cryptography
{
    public interface ICrypto
    {
        public string Encrypt(string plainText);
        public string Decrypt(string cipherText);
    }
}
