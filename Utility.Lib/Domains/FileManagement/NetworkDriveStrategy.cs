
using System.Net;

namespace Utility.Lib.Domains.FileManagement;

public sealed class NetworkDriveStrategy : IFileManagerStrategy
{
    public NetworkDriveStrategy(string location, string username, string password, string domain)
    {
        NetworkCredential networkCredential = new(@$"{domain}\{username}", password);
        CredentialCache credentialCache = new()
        {
            { new Uri(location), "Basic", networkCredential }
        };
    }
    public void Delete(string filePath)
    {
        File.Delete(filePath);
    }

    public async Task<byte[]> Download(string filePath)
    {
        byte[] fileBytes = await File.ReadAllBytesAsync(filePath);

        return fileBytes;
    }
    /// <summary>
    /// Copies bytes to the specified file path
    /// </summary>
    /// <param name="filePath">Entire file path including file name</param>
    /// <param name="bytes"></param>
    public async void Upload(string filePath, byte[] bytes)
    {
        await File.WriteAllBytesAsync(filePath, bytes);
    }
}