using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.ViewModel
{
    public class CartViewModel
    {
        public Item Product { get; set; }

        public int Quantity { get; set; }
    }
}
