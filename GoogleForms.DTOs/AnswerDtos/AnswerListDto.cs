using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class AnswerListDto : IDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public QuestionListDto? Question { get; set; }
        public string Description { get; set; }
        public AnswerType answerType { get; set; }
        public bool IsItUserAnswer { get; set; } = false;
        public bool IsSelected { get; set; } = false;
        public int NumberOfChoose { get; set; }
        public int? ChoiceRate { get; set; }
        public bool IsItLeastSelected { get; set; } = false;
        public bool IsItMostSelected { get; set; } = false;




    }
}
