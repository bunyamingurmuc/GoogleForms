using GoogleForms.Entities.Interface;

namespace GoogleForms.Entities
{
    public class Form : BaseEntity
    {
        public string FormTitle{ get; set; }
        public string FormDescription { get; set; }
        public List<Question>? Questions { get; set; }
    }
}
