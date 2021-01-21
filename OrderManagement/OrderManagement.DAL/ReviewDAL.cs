using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.DAL
{
    public class ReviewDAL : IReviewDAL
    {
        private readonly IConfiguration _configuration;

        public ReviewDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Review> GetReviewList()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Reviews
                    .OrderByDescending(n => n.ReviewNo)
                    .ToList();
            }
        }

        public Review GetReview(int reviewNo)
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Reviews
                    .FirstOrDefault(n => n.ReviewNo.Equals(reviewNo));
            }
        }

        public bool PostReview(Review review)
        {
            try
            {
                using (var db = new OrderManagementDbContext(_configuration))
                {
                    review.UserNo = db.Users.Single(u => u.UserID == review.UserID).UserNo;

                    //나중에 Order 연동해서 해결해야 함.
                    //review.ItemName = db.Items.Single(c => c.ItemNo == review.ItemNo).ItemName;

                    db.Reviews.Add(review);
                    db.SaveChanges();

                    return true;
                }
            }
            catch 
            { 
                return false;  
            }
        }

        public bool UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(int reviewNo)
        {
            throw new NotImplementedException();
        }
    }
}
