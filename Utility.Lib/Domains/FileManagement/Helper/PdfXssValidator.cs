
using iText.Kernel.Pdf;

namespace Utility.Lib.Domains.FileManagement.Helper;
public class PdfXssValidator : IXssValidator
{
    public bool Validate(Stream stream)
    {
        return !ContainsJavascript(stream);
    }

    public bool Validate(byte[] bytes)
    {
        throw new NotImplementedException();
    }

    private static bool ContainsJavascript(Stream stream)
    {
        using PdfReader pdfReader = new(stream);
        using PdfDocument pdfDocument = new(pdfReader);
        PdfNameTree javascript = pdfDocument.GetCatalog().GetNameTree(PdfName.JavaScript);

        if (javascript != null && javascript.GetKeys().Count > 0)
            return true;

        return false;
    }
}
