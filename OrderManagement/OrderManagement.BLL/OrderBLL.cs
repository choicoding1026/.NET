using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.BLL
{
    public class OrderBLL
    {
        private readonly IOrderDAL _orderDal;

        public OrderBLL(IOrderDAL orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetOrderList()
        {
            return _orderDal.GetOrderList();
        }

        public Order GetOrder(int orderNo)
        {
            return _orderDal.GetOrder(orderNo);
        }

        public bool PostOrder(Order order)
        {
            return _orderDal.PostOrder(order);
        }

        public bool UpdateOrder(Order order)
        {
            return _orderDal.UpdateOrder(order);
        }

        public bool DeleteOrder(int orderNo)
        {
            return _orderDal.DeleteOrder(orderNo);
        }
    }
}
