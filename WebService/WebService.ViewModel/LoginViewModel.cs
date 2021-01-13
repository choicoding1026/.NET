using System;
using System.ComponentModel.DataAnnotations;

namespace WebService.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "ID를 입력하세요.")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "PW를 입력하세요.")]
        public string UserPW { get; set; }
    }
}
