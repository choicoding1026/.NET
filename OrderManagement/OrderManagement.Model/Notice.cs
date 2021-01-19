using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Model
{
    public class Notice
    {
         /// <summary>
         /// 공지사항 번호
         /// </summary>
         [Key]
         public int NoticeNo { get; set; }
         
         /// <summary>
         /// 공지사항 제목
         /// </summary>
         [Required(ErrorMessage = "제목을 입력하세요.")]
         public string NoticeTitle { get; set; }
         
         /// <summary>
         /// 공지사항 내용
         /// </summary>
         [Required(ErrorMessage = "내용을 입력하세요.")]
         public string NoticeContents { get; set; }
         
         /// <summary>
         /// 공지사항 작성 날짜
         /// </summary>
         public DateTime NoticeWriteTime { get; set; }

         public string UserID { get; set; }

         [ForeignKey("UserID")]
         public virtual User User { get; set; }
    }
}
