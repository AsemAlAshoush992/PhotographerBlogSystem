using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System.IO;
using System.Xml.Linq;

namespace BlogPhotographerSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public async Task<string> UploadImageAndGetURL(IFormFile file)
        {
            string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "Files");
            if (file == null || file.Length == 0)
            {
                throw new Exception("Please Enter Valid File");
            }
            string newFileURL = Guid.NewGuid().ToString() + "" + file.FileName;
            using (var inputFile = new FileStream(Path.Combine(uploadFolder, newFileURL), FileMode.Create))
            {
                await file.CopyToAsync(inputFile);
            }
            return newFileURL;
        }

        [HttpPost]
        [Route("[action]/{fileName}")]
        public IActionResult GetFiles(string fileName)
        {
            string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "Files");
            if (string.IsNullOrEmpty(fileName))
            {
                return BadRequest("File name is not provided");
            }

            string filePath = Path.Combine(uploadFolder, fileName);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File not found");
            }

            var contentType = GetContentType(filePath);
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, contentType, fileName);
        }

        private string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(path, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }
    }
}
