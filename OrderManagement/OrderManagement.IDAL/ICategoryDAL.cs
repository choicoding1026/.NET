using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.IDAL
{
    public interface ICategoryDAL
    {
        List<Category> GetCategoryList();

        Category GetCategory(int cateNo);

        bool PostCategory(Category category);

        bool UpdateCategory(Category category);

        bool DeleteCategory(int cateNo);
    }
}
