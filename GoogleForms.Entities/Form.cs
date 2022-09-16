using GoogleForms.Entities.Interface;
using GoogleForms.Entities.UserEntities;
using System.Reflection.Metadata.Ecma335;

namespace GoogleForms.Entities
{
    public class Form : BaseEntity
    {
        public string FormTitle{ get; set; }
        public string FormDescription { get; set; }
        public List<Question>? Questions { get; set; }
        public List<AppUser> appUsers { get; set; }
    }
}
