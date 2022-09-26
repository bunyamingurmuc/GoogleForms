using GoogleForms.Common.Enums;
using GoogleForms.Entities.Interface;

namespace GoogleForms.Entities
{
    public class Answer:BaseEntity
    {
        public int QuestionId { get; set; }
        public Question Question{ get; set; }
        public string Description { get; set; }
        public AnswerType answerType{ get; set; }
        public bool IsItUserAnswer { get; set; } = false;
        public int NumberOfChoose { get; set; }
        public int? ChoiceRate { get; set; }
        public bool IsItLeastSelected { get; set; } = false;
        public bool IsItMostSelected { get; set; } = false;




    }
}
