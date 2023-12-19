namespace Utility.Lib.Domains.FileManagement;

public sealed class FileSystemStrategy : IFileManagerStrategy
{
    public void Delete(string filePath)
    {
        File.Delete(filePath);
    }

    public async Task<byte[]> Download(string filePath)
    {
        byte[] fileBytes = await File.ReadAllBytesAsync(filePath);

        return fileBytes;
    }

    public async void Upload(string filePath, byte[] bytes)
    {
        await File.WriteAllBytesAsync(filePath, bytes);
    }
}