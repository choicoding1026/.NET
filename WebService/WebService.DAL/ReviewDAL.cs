using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebService.DAL.DBContext;
using WebService.IDAL;
using WebService.Model;

namespace WebService.DAL
{
    public class ReviewDAL : IReviewDAL
    {
        private readonly IConfiguration _configuration;

        public ReviewDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// 1. 리뷰 목록
        /// </summary>
        /// <returns></returns>
        public List<Review> GetReviewList()
        {
            using (var db = new WebServiceDBContext(_configuration))
            {
                return db.Reviews
                    .OrderByDescending(n => n.ReviewNo)
                    .ToList();
            }
        }

        /// <summary>
        /// 2. 리뷰 상세보기
        /// </summary>
        /// <param name="reviewNo"></param>
        /// <returns></returns>
        public Review GetReview(int reviewNo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 3. 리뷰 등록
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        public bool PostReview(Review review)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 4. 리뷰 수정
        /// </summary>
        /// <param name="reviewNo"></param>
        /// <returns></returns>
        public bool UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 5. 리뷰 삭제
        /// </summary>
        /// <param name="reviewNo"></param>
        /// <returns></returns>
        public bool DeleteReview(int reviewNo)
        {
            throw new NotImplementedException();
        }
    }
}
