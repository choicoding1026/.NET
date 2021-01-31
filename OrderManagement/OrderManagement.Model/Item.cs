using System.ComponentModel.DataAnnotations;

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
        public int Quantity { get; set; }

        [Required]
        public string Cate { get; set; }
    }
}
