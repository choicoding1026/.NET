using System.ComponentModel.DataAnnotations;

namespace WebApplicationBoard.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key] // pk설정
        public int UserNo { get; set; }
        
        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage = "이름을 입력하시오.")] // Not Null 설정
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage = "ID를 입력하시오.")]
        public string UserID { get; set; }

        /// <summary>
        /// 사용자 PW
        /// </summary>
        [Required(ErrorMessage = "PW를 입력하시오.")]
        public string UserPW { get; set; }
    }
}
