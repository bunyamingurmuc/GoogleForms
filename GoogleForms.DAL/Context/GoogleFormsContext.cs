using GoogleForms.DAL.Configurations;
using GoogleForms.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoogleForms.DAL.Context
{
    public class GoogleFormsContext:DbContext
    {
        public GoogleFormsContext(DbContextOptions<GoogleFormsContext> options) : base(options)
        {
        }
        public DbSet<Form>? Forms{ get; set; }
        public DbSet<Question>? Questions{ get; set; }
        public DbSet<Answer>? Answers{ get; set; }
        public DbSet<UserAnswer>? UserAnswer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>().Navigation(x => x.Questions).AutoInclude();
            modelBuilder.Entity<Question>().Navigation(x => x.Answers).AutoInclude();
           modelBuilder.ApplyConfiguration(new FormConfigurations());
            modelBuilder.ApplyConfiguration(new QuestionConfigurations());
            modelBuilder.ApplyConfiguration(new AnswerConfigurations());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
