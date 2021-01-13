using System;
using System.Collections.Generic;
using WebService.IDAL;
using WebService.Model;

namespace WebService.BLL
{
    public class ReviewBLL
    {
        private readonly IReviewDAL _reviewDal;

        public ReviewBLL(IReviewDAL reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public List<Review> GetReviewList()
        {
            return _reviewDal.GetReviewList();
        }

        public Review GetReview(int reviewNo)
        {
            if (reviewNo <= 0) throw new ArgumentException();
            return _reviewDal.GetReview(reviewNo);
        }

        public bool PostReview(Review review)
        {
            if (review == null) throw new ArgumentNullException();
            return _reviewDal.PostReview(review);
        }

        public bool UpdateReview(Review review)
        {
            if (review == null) throw new ArgumentNullException();
            return _reviewDal.UpdateReview(review);
        }

        public bool DeleteReview(int reviewNo)
        {
            if (reviewNo <= 0) throw new ArgumentException();
            return _reviewDal.DeleteReview(reviewNo);
        }
    }
}
