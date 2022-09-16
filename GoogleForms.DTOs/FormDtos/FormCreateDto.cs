using GoogleForms.DTOs.Interfaces;
using GoogleForms.Entities.UserEntities;

namespace GoogleForms.DTOs
{
    public class FormCreateDto:IDto
    {

        public string FormTitle { get; set; }
        public string FormDescription { get; set; }
        public List<AppUser> appUsers { get; set; }

        //public List<QuestionListDto>? Questions { get; set; }
    }
}
