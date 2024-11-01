using Utility.Lib.Domains.Cryptography;

namespace Utility.Tests;
public class CryptoTransform
{
    [Theory]
    [InlineData("Hello World!", "asdhaoisdpoasud**")]
    [InlineData("Hey!", "asdsdasdasdhaoisdpoasud")]
    [InlineData("Craaaaaaazy", "asdhad@eq2ed@oisdpoa")]
    public void Should_Match_With_PlainText_After_Decryption(string plainText, string secretKey)
    {
        // Arrange
        ICrypto crypto = new Utility.Lib.Domains.Cryptography.CryptoTransform(secretKey);

        // Act
        string cipherText = crypto.Encrypt(plainText);
        string decryptedText = crypto.Decrypt(cipherText);

        // Assert
        Assert.Equal(plainText, decryptedText);
    }
}
