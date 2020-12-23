using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationBoard.Models
{
    public class Board
    {
        [Key] // pk설정
        public int BoardNo { get; set; }

        [Required(ErrorMessage = "제목을 입력하세요.")]
        public string BoardTitle { get; set; }

        [Required(ErrorMessage = "내용을 입력하세요.")]
        public string BoardContents { get; set; }

        [Required]
        public int UserNo { get; set; }

        [ForeignKey("UserNo")] // join
        public virtual User User { get; set; }
    }
}
