using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderManagement.Model
{
    public class Item
    {
        public int ItemNo { get; set; }

        [Key]
        public string ItemName { get; set; }

        public int Price { get; set; }

    }
}
