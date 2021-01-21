using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.IDAL
{
    public interface IOrderDAL
    {
        List<Order> GetOrderList();

        Order GetOrder(int orderNo);

        bool PostOrder(Order order);

        bool UpdateOrder(Order order);

        bool DeleteOrder(int orderNo);

    }
}
