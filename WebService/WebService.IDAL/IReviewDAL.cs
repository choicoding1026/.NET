using System;
using System.Collections.Generic;
using System.Text;
using WebService.Model;

namespace WebService.IDAL
{
    public interface IReviewDAL
    {
        /// <summary>
        /// 1. 리뷰 목록
        /// </summary>
        /// <returns></returns>
        List<Review> GetReviewList();

        /// <summary>
        /// 2. 리뷰 상세보기
        /// </summary>
        /// <param name="reviewNo"></param>
        /// <returns></returns>
        Review GetReview(int reviewNo);

        /// <summary>
        /// 3. 리뷰 등록
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        bool PostReview(Review review);

        /// <summary>
        /// 4. 리뷰 수정
        /// </summary>
        /// <param name="reviewNo"></param>
        /// <returns></returns>
        bool UpdateReview(Review review);

        /// <summary>
        /// 5. 리뷰 삭제
        /// </summary>
        /// <param name="reviewNo"></param>
        /// <returns></returns>
        bool DeleteReview(int reviewNo);
    }
}
