using System.Threading.Tasks;

namespace Utility.Lib.Domains.FileManagement
{
    public sealed class FileManagerContext
    {
        private IFileManagerStrategy _strategy;

        public FileManagerContext(IFileManagerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetFileManagerStrategy(IFileManagerStrategy strategy) => _strategy = strategy;

        public void Delete(string path)
        {
            _strategy.Delete(path);
        }

        public async Task<byte[]> Download(string path)
        {
            byte[] fileBytes = await _strategy.Download(path);

            return fileBytes;
        }

        public void Upload(string path, byte[] bytes)
        {
            _strategy.Upload(path, bytes);
        }
    }
}
