using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.MVC.Models
{
    public class CartList
    {
        public static int UserNo { get; set; }

        public static List<Item> Items = new List<Item>();
    }
}
