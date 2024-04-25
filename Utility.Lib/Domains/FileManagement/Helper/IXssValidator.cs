using System.IO;

namespace Utility.Lib.Domains.FileManagement.Helper
{
    public interface IXssValidator
    {
        /// <summary>
        /// Returns true when the stream doesn't contain any xss, otherwise returns false
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        bool Validate(Stream stream);
        bool Validate(byte[] bytes);
    }
}
