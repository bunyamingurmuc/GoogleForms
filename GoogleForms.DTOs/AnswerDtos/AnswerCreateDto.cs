using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class AnswerCreateDto:IDto
    {
        
        public int QuestionId { get; set; }
        public QuestionListDto Question { get; set; }
        public string Description { get; set; }
        public AnswerType answerType { get; set; }
        public bool IsItTrueAnswer { get; set; } = false;
        public bool IsSelected { get; set; } = false;




    }
}
