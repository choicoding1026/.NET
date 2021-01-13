using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebService.MVC6.Models;
using WebService.BLL;

namespace WebService.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeBLL _noticeBll;

        public HomeController(NoticeBLL noticeBll)
        {
            _noticeBll = noticeBll;
        }

        public IActionResult Index()
        {
            var list = _noticeBll.GetNoticeList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
