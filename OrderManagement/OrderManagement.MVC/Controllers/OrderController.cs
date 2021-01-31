using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderManagement.BLL;
using OrderManagement.Model;
using OrderManagement.MVC.Helpers;
using OrderManagement.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderBLL _orderBll;

        public OrderController(OrderBLL orderBll)
        {
            _orderBll = orderBll;
        }

        public IActionResult Index()
        {
            var list = _orderBll.GetItems();
            return View(list);
        }

        public IActionResult Management()
        {
            var list = _orderBll.GetOrderList();
            return View(list);
        }

        public List<CartViewModel> cart = new List<CartViewModel>();

        [HttpPost]
        public IActionResult Cart(int itemNo)
        {
            
            if (HttpContext.Session.Get("Cart") == null)
            {
                var product = _orderBll.Getitem(itemNo);

                cart.Add(new CartViewModel
                {
                    Product = product,
                    Quantity = 1
                });
                HttpContext.Session.SetObject("Cart", cart);
            }
            else
            {
                HttpContext.Session.SetObject("Cart", cart); ;
                var count = cart.Count();
                var product = _orderBll.Getitem(itemNo);
                for (int i = 0; i < count; i++)
                {
                    if (cart[i].Product.ItemNo == itemNo)
                    {
                        int prevQty = cart[i].Quantity;
                        cart.Remove(cart[i]);
                        cart.Add(new CartViewModel()
                        {
                            Product = product,
                            Quantity = prevQty + 1
                        });
                        break;
                    }
                    else
                    {
                        var prd = cart.Where(x => x.Product.ItemNo == itemNo).SingleOrDefault();

                        if (prd == null)
                        {
                            cart.Add(new CartViewModel()
                            {
                                Product = product,
                                Quantity = 1
                            });
                        }
                    }
                }
                HttpContext.Session.SetObject("Cart", cart);
            }
            return Redirect("Index");
        }

        public IActionResult Cart()
        {
            ViewBag.cartList = cart;
            return View(cart);
        }
        /*
        [HttpPost]
        public IActionResult Cart(int itemNo)
        {
            var product = _orderBll.Getitem(itemNo);

            var count = 0;
            foreach (var item in CartList.Items)
            {
                if (item.ItemNo.Equals(product.ItemNo))
                {
                    count++;
                }
            }

            if (count == 0)
            {
                CartList.Items.Add(product);
            }

            return View(CartList.Items);
        }

        public IActionResult Cart() 
        {
            var list = CartList.Items;
            return View(list);
        }
        */
        public IActionResult Pay()
        {
            return View();
        }
    }
}
