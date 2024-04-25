using Utility.Lib.Domains.FileManagement.Helper;

namespace Utility.Tests;

public class PdfXssValidatorTest
{
    [Fact]
    public void Should_ReturnFalse_When_Validating_Pdf_With_Xss_Content()
    {
        // Arrange
        string filepath = @$"wwwroot\xss.pdf";
        var fileBytes = File.ReadAllBytes(filepath);

        using MemoryStream stream = new(fileBytes);
        IXssValidator xssValidator = new PdfXssValidator();

        // Act
        bool isValidFile = xssValidator.Validate(stream);

        // Assert
        Assert.False(isValidFile);
    }
}