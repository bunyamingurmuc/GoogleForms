using GoogleForms.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace GoogleForms.DTOs
{
    public class UserAnswerCreateDto
    {
        public int QuestionId { get; set; }
        public QuestionListDto Question { get; set; }

        [Required(ErrorMessage = "Açıklama Zorunlu")]
        public string Description { get; set; }
        public AnswerType answerType { get; set; }
        public int NumberOfChoose { get; set; }

    }
}
