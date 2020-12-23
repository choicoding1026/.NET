using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplicationBoard.DataContext;
using WebApplicationBoard.Models;
using WebApplicationBoard.ViewModels;

namespace WebApplicationBoard.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet] //default
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // ID, PW 필수
            if (ModelState.IsValid)
            {
                using (var db = new BoardDBContext())
                {
                    // Linq - 메서드 체이닝
                    // => : go to
                    var user = db.Users.FirstOrDefault(u => u.UserID.Equals(model.UserID) && u.UserPW.Equals(model.UserPW));
                    
                    if (user != null)
                    {
                        // 로그인 성공
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                        return RedirectToAction("LoginSuccess", "Home");
                    }
                }
                // 로그인 실패
                ModelState.AddModelError(string.Empty, "다시 입력해주세요.");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index", "Home");
        }
        
        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 회원가입 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                using(var db = new BoardDBContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges(); // Commit;
                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
