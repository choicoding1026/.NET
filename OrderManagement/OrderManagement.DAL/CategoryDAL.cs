using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrderManagement.DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        private readonly IConfiguration _configuration;

        public CategoryDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Category> GetCategoryList()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Categories
                    .OrderByDescending(n => n.CateNo)
                    .ToList();
            }
        }

        public Category GetCategory(int cateNo)
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Categories
                    .FirstOrDefault(n => n.CateNo.Equals(cateNo));
            }
        }

        public bool PostCategory(Category category)
        {
            try
            {
                using (var db = new OrderManagementDbContext(_configuration))
                {
                    db.Categories.Add(category);
                    db.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int cateNo)
        {
            throw new NotImplementedException();
        }
    }
}
