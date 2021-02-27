using Microsoft.AspNetCore.Http;

namespace AzureBlob.Api.Models
{
    public class FileModel
    {
        public IFormFile ImageFile{get;set;}
    }
}