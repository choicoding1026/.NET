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
    public class CategoryController : Controller
    {
        private readonly CategoryBLL _categoryBll;

        public CategoryController(CategoryBLL categoryBll)
        {
            _categoryBll = categoryBll;
        }

        public IActionResult Index()
        {
            var list = _categoryBll.GetCategoryList();
            return View(list);
        }

        public IActionResult Detail(int cateNo)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != null)
            {
                return RedirectToAction("Signin", "Account");
            }

            var cate = _categoryBll.GetCategory(cateNo);
            return View(cate);
        }

        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != "admin")
            {
                return Redirect("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != "admin")
            {
                return Redirect("Index");
            }

            if (ModelState.IsValid)
            {
                bool result = _categoryBll.PostCategory(category);
                if (result == true)
                {
                    return Redirect("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "카테고리 등록에 실패했습니다.");
                }
            }
            ModelState.AddModelError(string.Empty, "필수 항목을 입력해주세요.");
            return View(category);
        }

        public IActionResult Edit()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != "admin")
            {
                return Redirect("Index");
            }

            return View();
        }

        public IActionResult Delete()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != "admin")
            {
                return Redirect("Index");
            }

            return View();
        }
    }
}
