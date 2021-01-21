using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace OrderManagement.MVC.Controllers
{
    public class UploadController : Controller
    {
        private readonly IHostEnvironment _environment;

        public UploadController(IHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpPost, Route("api/upload")]
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, @"images\upload");
            var fileFullName = file.FileName.Split('.');
            var fileName = $"{Guid.NewGuid()}.{fileFullName[1]}";

            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return Ok(new { file = "/images/upload/" + fileName, success = true });
        }
    }
}
