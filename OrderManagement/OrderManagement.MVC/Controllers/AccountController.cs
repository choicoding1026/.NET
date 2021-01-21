using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL;
using OrderManagement.Model;
using OrderManagement.ViewModel;
using System;

namespace OrderManagement.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserBLL _userBll;

        public AccountController(UserBLL userBll)
        {
            _userBll = userBll;
        }

        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signin(SigninViewModel signinModel)
        {
            if (ModelState.IsValid)
            {
                var result = _userBll.Signin(signinModel);
                if (result == true)
                { 
                    HttpContext.Session.SetString("USER_LOGIN_KEY", signinModel.UserID);
                    return RedirectToAction("Index", "Home");
                } 
                else
                {
                    ModelState.AddModelError(string.Empty, "다시 입력해주세요.");
                }
            }
            ModelState.AddModelError(string.Empty, "필수 항목을 입력해주세요.");
            return View(signinModel);
        }

        public IActionResult Signout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                _userBll.Signup(user);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
