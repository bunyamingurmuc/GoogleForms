using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class AnswerUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public QuestionUpdateDto Question { get; set; }
        public string Description { get; set; }
    }
}
