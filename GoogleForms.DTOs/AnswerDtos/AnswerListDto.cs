using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class AnswerListDto : IDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public QuestionListDto Question { get; set; }
        public string Description { get; set; }
    }
}
