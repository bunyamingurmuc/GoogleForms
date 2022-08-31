using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class QuestionCreateDto:IDto
    {
        public QuestionCreateDto()
        {
            UserAnswers = new List<AnswerListDto>();
        }
        public string QuestionTitle { get; set; }
        public bool IsRequired { get; set; }
        public QuestionType QuestionType { get; set; }
        public int FormId { get; set; }
        public List<AnswerListDto>? Answers { get; set; }
        public List<AnswerListDto>? UserAnswers { get; set; }
        public bool IsAnswered { get; set; }
        //public FormListDto Form { get; set; }


    }

}
