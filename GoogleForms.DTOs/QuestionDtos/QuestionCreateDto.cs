using GoogleForms.Common.Enums;
using GoogleForms.DTOs.Interfaces;

namespace GoogleForms.DTOs
{
    public class QuestionCreateDto:IDto
    {

        public string QuestionTitle { get; set; }
        public bool IsRequired { get; set; }
        public QuestionType QuestionType { get; set; }
        public int FormId { get; set; }
        //public FormListDto Form { get; set; }

       
    }
   
}
