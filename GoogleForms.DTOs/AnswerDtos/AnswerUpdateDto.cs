using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class AnswerUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public QuestionUpdateDto Question { get; set; }
        public string Description { get; set; }
        public AnswerType answerType { get; set; }
        public bool IsItTrueAnswer { get; set; } = false;
        public bool IsSelected { get; set; } = false;




    }
}
