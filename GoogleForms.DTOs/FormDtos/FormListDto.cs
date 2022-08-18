using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class FormListDto : IDto
    {
        public int Id { get; set; }
        public string FormTitle { get; set; }
        public string FormDescription { get; set; }
        public List<QuestionListDto> Questions { get; set; }
    }
}