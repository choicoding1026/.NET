using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.BLL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.MVC.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ReviewBLL _reviewBll;

        public ReviewController(ReviewBLL reviewBll)
        {
            _reviewBll = reviewBll;
        }

        public IActionResult Index()
        {
            var list = _reviewBll.GetReviewList();
            return View(list);
        }

        public IActionResult Detail(int reviewNo)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Signin", "Account");
            }

            var review = _reviewBll.GetReview(reviewNo);
            return View(review);
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
        public IActionResult Add(Review review)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") == null)
            {
                return RedirectToAction("Signin", "Account");
            }

            if (ModelState.IsValid)
            {
                review.ReviewWriteTime = DateTime.Now;
                review.UserID = HttpContext.Session.GetString("USER_LOGIN_KEY"); 

                bool result = _reviewBll.PostReview(review);
                if (result == true)
                {
                    return Redirect("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "리뷰 등록에 실패했습니다.");
                }
            }
            ModelState.AddModelError(string.Empty, "필수 항목을 입력해주세요.");
            return View(review);
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
