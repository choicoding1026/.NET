using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.BLL
{
    public class CategoryBLL
    {
        private readonly ICategoryDAL _categoryDal;

        public CategoryBLL(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetCategoryList()
        {
            return _categoryDal.GetCategoryList();
        }

        public Category GetCategory(int cateNo)
        {
            if (cateNo <= 0) throw new ArgumentException();
            return _categoryDal.GetCategory(cateNo);
        }

        public bool PostCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException();
            return _categoryDal.PostCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException();
            return _categoryDal.UpdateCategory(category);
        }

        public bool DeleteCategory(int cateNo)
        {
            if (cateNo <= 0) throw new ArgumentException();
            return _categoryDal.DeleteCategory(cateNo);
        }
    }
}
