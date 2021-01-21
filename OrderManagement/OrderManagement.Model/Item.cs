using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement.Model
{
    public class Item
    {
        [Key]
        public int ItemNo { get; set; }

        [Required]
        public string ItemID { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Cate { get; set; }
    }
}
