using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL;
using OrderManagement.MVC.Models;
using System.Diagnostics;

namespace OrderManagement.MVC.Controllers
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
            return View(list);
        }

        public IActionResult Detail(int noticeNo)
        {
            var notice = _noticeBll.GetNotice(noticeNo);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
