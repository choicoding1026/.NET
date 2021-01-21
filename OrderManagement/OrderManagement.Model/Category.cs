using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderManagement.Model
{
    public class Category
    {
        [Key]
        public int CateNo { get; set; }

        [Required]
        public string CateName { get; set; }
    }
}
