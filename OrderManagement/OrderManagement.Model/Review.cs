using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement.Model
{
    public class Review
    {
        /// <summary>
        /// 리뷰 번호
        /// </summary>
        [Key]
        public int ReviewNo { get; set; }

        /// <summary>
        /// 리뷰 제목
        /// </summary>
        [Required(ErrorMessage = "제목을 입력하세요.")]
        public string ReviewTitle { get; set; }

        /// <summary>
        /// 리뷰 내용
        /// </summary>
        [Required(ErrorMessage = "내용을 입력하세요.")]
        public string ReviewContents { get; set; }

        /// <summary>
        /// 리뷰 작성 날짜
        /// </summary>
        public DateTime ReviewWriteTime { get; set; }

        [Required]
        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [Required]
        public string ItemName { get; set; }

        [ForeignKey("ItemName")]
        public virtual Item Item { get; set; }
    }
}
