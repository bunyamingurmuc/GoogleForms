using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class FormUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public string FormTitle { get; set; }
        public string FormDescription { get; set; }
        public List<QuestionUpdateDto> Questions { get; set; }
    }
}
