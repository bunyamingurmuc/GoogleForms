using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class FormCreateDto:IDto
    {
        
        public string FormTitle { get; set; }
        public string FormDescription { get; set; }
        //public List<QuestionListDto>? Questions { get; set; }
    }
}
