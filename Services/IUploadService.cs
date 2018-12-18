using Microsoft.WindowsAzure.Storage.Blob;

namespace Coinrr.Services
{
    public interface IUploadService 
    {
        CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
    }
}