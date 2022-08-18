using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class AnswerCreateDto:IDto
    {
        
        public int QuestionId { get; set; }
        public QuestionCreateDto Question { get; set; }
        public string Description { get; set; }
    }
}
