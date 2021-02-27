using System.Threading.Tasks;
using AzureBlob.Api.Models;

namespace AzureBlob.Api.Logics
{
    public interface IFileManagerLogic
    {
        Task Upload(FileModel model);
        Task<byte[]> Get(string imageName);
        Task Delete(string imageName);
    }
}