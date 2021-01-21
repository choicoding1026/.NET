using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement.Model
{
    public class Order
    {
        [Key]
        public int OrderNo { get; set; }

        public string UserID { get; set; }

        public int UserNo { get; set; }

        [ForeignKey("UserNo")]
        public virtual User User { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Product { get; set; }

        public string ItemID { get; set; }

        public int ItemNo { get; set; }

        [ForeignKey("ItemNo")]
        public virtual Item Item { get; set; }

        public string Amount { get; set; }
    }
}
