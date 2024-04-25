using System.Threading.Tasks;

namespace Utility.Lib.Domains.FileManagement
{
    public interface IFileManagerStrategy
    {
        void Upload(string path, byte[] bytes);
        Task<byte[]> Download(string path);
        void Delete(string path);
    }
}
