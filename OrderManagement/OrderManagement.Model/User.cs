using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement.Model
{
    public class User
    {
        [Key]
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage = "ID를 입력하시오.")]
        public string UserID { get; set; }

        /// <summary>
        /// 사용자 PW
        /// </summary>
        [Required(ErrorMessage = "비밀번호를 입력하시오.")]
        public string UserPW { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage = "이름을 입력하시오.")] // Not Null 설정
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 전화번호
        /// </summary>
        [Required(ErrorMessage = "전화번호를 입력하시오.")]
        public string UserPhone { get; set; }

        /// <summary>
        /// 사용자 주소
        /// </summary>
        [Required(ErrorMessage = "주소를 입력하시오.")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 사용자 예치금
        /// </summary>
        public int Money { get; set; }

        /// <summary>
        /// 사용자 가입날짜
        /// </summary>
        public DateTime SignUpDate { get; set; }
    }
}
