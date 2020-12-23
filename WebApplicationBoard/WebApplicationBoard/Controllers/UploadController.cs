using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBoard.Controllers
{
    public class UploadController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public UploadController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        [HttpPost, Route("api/upload")]
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {
            /// 이미지나 파일을 업로드할 때 필요한 구성
            /// 1. path
            /// 2. filename - DateTime, GUID
            /// 3. extension - jpg, txt ..

            var path = Path.Combine(_environment.WebRootPath, @"images\upload");
            var fileFullName = file.FileName.Split('.');
            var fileName = $"{Guid.NewGuid()}.{fileFullName[1]}";

            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return Ok(new { file = "/images/upload/" + fileName, success = true });

            /// URL 접근 방법
            /// ASP.NET - HOSTNAME/ + api/upload
            /// JS - HOSTNAME + /api/upload
        }
    }
}

