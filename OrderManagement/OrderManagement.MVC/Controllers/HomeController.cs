using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL;
using OrderManagement.Model;
using System;

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
            var message = HttpContext.Session.GetString("USER_LOGIN_KEY");
            Console.WriteLine(message);
            var list = _noticeBll.GetNoticeList();
            return View(list);
        }

        public IActionResult Detail(int noticeNo)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != null)
            {
                return RedirectToAction("Signin", "Account");
            }

            var notice = _noticeBll.GetNotice(noticeNo);
            return View(notice);
        }

        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Signin", "Account");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Add(Notice notice)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Signin", "Account");
            }

            if (ModelState.IsValid)
            {
                notice.NoticeWriteTime = DateTime.Now;
                bool result = _noticeBll.PostNotice(notice);
                if (result == true)
                {
                    return Redirect("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "회원가입에 실패했습니다.");
                }
            }
            ModelState.AddModelError(string.Empty, "필수 항목을 입력해주세요.");
            return View(notice);
        }

        public IActionResult Edit()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Signin", "Account");
            }

            return View();
        }

        public IActionResult Delete()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Signin", "Account");
            }

            return View();
        }
    }
}
