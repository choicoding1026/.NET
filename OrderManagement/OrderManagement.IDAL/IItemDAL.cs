using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.IDAL
{
    public interface IItemDAL
    {
        List<Item> GetItemList();

        List<Category> GetCategories();

        Item GetItem(int itemNo);

        bool PostItem(Item item);

        bool UpdateItem(Item item);

        bool DeleteItem(int itemNo);
    }
}
