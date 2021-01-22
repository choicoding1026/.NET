using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.DAL
{
    public class OrderDAL : IOrderDAL
    {
        public List<Order> GetOrderList()
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItems()
        {
            throw new NotImplementedException();
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
