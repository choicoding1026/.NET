using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using OrderManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.DAL
{
    public class OrderDAL : IOrderDAL
    {
        private readonly IConfiguration _configuration;

        public OrderDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Order> GetOrderList()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Orders
                    .OrderByDescending(n => n.OrderNo)
                    .ToList();
            }
        }

        public List<Item> GetItems()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Items
                    .OrderByDescending(n => n.ItemNo)
                    .ToList();
            }
        }

        public Item GetItem(int itemNo)
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Items
                    .FirstOrDefault(n => n.ItemNo.Equals(itemNo));
            }
        }

        public Order GetOrder(int orderNo)
        {
            throw new NotImplementedException();
        }

        public bool PostOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(int orderNo)
        {
            throw new NotImplementedException();
        }
    }
}
