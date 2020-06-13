using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace JobApplying.Models.FileUploading
{
    public class UploadingFile
    {
        private IWebHostEnvironment _environment;
        private string _subDirectory;
        public string FileKey { get; private set; }

        public UploadingFile(IWebHostEnvironment environment,string subDirectory)
        {
            _environment = environment;
            _subDirectory = subDirectory;
        }

        public  async Task<bool> Upload(IFormFile formFile)
        {
            var guid = Guid.NewGuid();
            var unique = guid + "_" + formFile.FileName;
            var path = Path.Combine(_environment.WebRootPath, _subDirectory, unique);
            try
            {
                await formFile.CopyToAsync(new FileStream(path, FileMode.Create));
                FileKey = unique;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}