namespace Utility.Lib.Domains.FileManagement.Helper;
public interface IXssValidator
{
    bool Validate(Stream stream);
    bool Validate(byte[] bytes);
}
