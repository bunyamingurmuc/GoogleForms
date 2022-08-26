using GoogleForms.DTOs.Interfaces;
using System.Reflection.Metadata;

namespace GoogleForms.DTOs
{
    public class FormListDto : IDto
    {
        public FormListDto()
        {
            Questions = new List<QuestionListDto>();
        }
        public int Id { get; set; }
        public string FormTitle { get; set; }
        public string FormDescription { get; set; }
        public List<QuestionListDto> Questions { get; set; }
    }
}