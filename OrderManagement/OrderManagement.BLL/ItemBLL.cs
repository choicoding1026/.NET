using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.BLL
{
    public class ItemBLL
    {
        private readonly IItemDAL _itemDal;

        public ItemBLL(IItemDAL itemDal)
        {
            _itemDal = itemDal;
        }
        public List<Item> GetItemList()
        {
            return _itemDal.GetItemList();
        }

        public List<Category> GetCategories()
        {
            return _itemDal.GetCategories();
        }

        public Item GetItem(int itemNo)
        {
            if (itemNo <= 0) throw new ArgumentException();
            return _itemDal.GetItem(itemNo);
        }

        public bool PostItem(Item item)
        {
            if (item == null) throw new ArgumentNullException();
            return _itemDal.PostItem(item);
        }

        public bool UpdateItem(Item item)
        {
            if (item == null) throw new ArgumentNullException();
            return _itemDal.UpdateItem(item);
        }

        public bool DeleteItem(int itemNo)
        {
            if (itemNo <= 0) throw new ArgumentException();
            return _itemDal.DeleteItem(itemNo);
        }
    }
}
