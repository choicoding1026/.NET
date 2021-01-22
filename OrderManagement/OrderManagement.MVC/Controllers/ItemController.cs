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
    public class ItemController : Controller
    {
        private readonly ItemBLL _itemBll;

        public ItemController(ItemBLL itemBll)
        {
            _itemBll = itemBll;
        }

        public IActionResult Index()
        {
            var list = _itemBll.GetItemList();
            return View(list);
        }

        public IActionResult Detail(int itemNo)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != null)
            {
                return RedirectToAction("Signin", "Account");
            }

            var item = _itemBll.GetItem(itemNo);
            return View(item);
        }

        public IActionResult Add()
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != "admin")
            {
                return Redirect("Index");
            }

            var category = _itemBll.GetCategories();
            ViewBag.cateList = category;

            return View();
        }

        [HttpPost]
        public IActionResult Add(Item item)
        {
            if (HttpContext.Session.GetString("USER_LOGIN_KEY") != "admin")
            {
                return Redirect("Index");
            }

            if (ModelState.IsValid)
            {
                bool result = _itemBll.PostItem(item);
                if (result == true)
                {
                    return Redirect("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "상품 등록에 실패했습니다.");
                }
            }
            ModelState.AddModelError(string.Empty, "필수 항목을 입력해주세요.");
            return View(item);
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
