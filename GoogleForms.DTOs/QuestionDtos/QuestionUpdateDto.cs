using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class QuestionUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public bool IsRequired { get; set; }
        public QuestionType QuestionType { get; set; }
        public int FormId { get; set; }
        public FormUpdateDto Form { get; set; }
        public List<AnswerUpdateDto> Answers { get; set; }
    }
}
