using GoogleForms.Common.Enums;
using GoogleForms.Entities.Interface;

namespace GoogleForms.Entities
{
    public class Question : BaseEntity
    {
        public string QuestionTitle { get; set; }
        public bool IsRequired { get; set; }
        public QuestionType QuestionType{ get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
        public List<Answer> Answers { get; set; }

    }
 
}
