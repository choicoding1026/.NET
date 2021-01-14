using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderManagement.Model
{
    public class Item
    {
        [Key]
        public int ItemNo { get; set; }

        public string ItemName { get; set; }

        public int Price { get; set; }

    }
}
