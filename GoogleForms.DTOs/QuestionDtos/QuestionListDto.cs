using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class QuestionListDto: IDto
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public bool IsRequired { get; set; }
        public QuestionType QuestionType { get; set; }
        public int FormId { get; set; }
        public FormListDto Form { get; set; }
        public List<AnswerListDto> Answers { get; set; }
    }
}
