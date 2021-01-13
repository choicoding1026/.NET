using System;
using System.ComponentModel.DataAnnotations;

namespace WebService.Model
{
    public class User
    {
        /// <summary>
        /// 유저 번호
        /// </summary>
        [Key]
        public int UserNo { get; set; }

        /// <summary>
        /// 유저 아이디
        /// </summary>
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        public string UserID { get; set; }

        /// <summary>
        /// 유저 이름
        /// </summary>
        [Required(ErrorMessage = "이름을 입력하세요.")]
        public string UserName { get; set; }

        /// <summary>
        /// 유저 비밀번호
        /// </summary>
        [Required(ErrorMessage = "패스워드를 입력하세요.")]
        public string UserPW { get; set; }

        /// <summary>
        /// 유저 전화번호
        /// </summary>
        [Required(ErrorMessage = "전화번호를 입력하세요.")]
        public string Phone { get; set; }

        /// <summary>
        /// 유저 주소
        /// </summary>
        [Required(ErrorMessage = "주소를 입력하세요.")]
        public string Address { get; set; }

        /// <summary>
        /// 유저 보유금액
        /// </summary>
        public string Money { get; set; }

        /// <summary>
        /// 유저 가입날짜
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
