using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.DAL
{
    public class ItemDAL: IItemDAL
    {
        private readonly IConfiguration _configuration;

        public ItemDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Item> GetItemList()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Items
                    .OrderByDescending(n => n.ItemID)
                    .ToList();
            }
        }

        public List<Category> GetCategories()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Categories
                    .OrderByDescending(n => n.CateNo)
                    .ToList();
            }
        }

        public Item GetItem(int itemNo)
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Items
                    .FirstOrDefault(n => n.ItemID.Equals(itemNo));
            }
        }

        public bool PostItem(Item item)
        {
            try
            {
                using (var db = new OrderManagementDbContext(_configuration))
                {
                    db.Items.Add(item);
                    db.SaveChanges();

                    return true;
                }
            }
            catch 
            {
                return false;    
            }
        }

        public bool UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int itemNo)
        {
            throw new NotImplementedException();
        }
    }
}
