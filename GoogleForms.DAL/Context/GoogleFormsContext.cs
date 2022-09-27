using GoogleForms.DAL.Configurations;
using GoogleForms.Entities;
using GoogleForms.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;

namespace GoogleForms.DAL.Context
{
    public class GoogleFormsContext: Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<AppUser,AppRole,int>
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
            //modelBuilder.Entity<Form>().Navigation(x => x.appUsers).AutoInclude();
            
            modelBuilder.Entity<AppUser>().Navigation(x => x.Forms).AutoInclude();
            modelBuilder.Entity<Answer>().Navigation(x => x.Question).AutoInclude();
            modelBuilder.Entity<Question>().Navigation(x => x.Answers).AutoInclude();
            modelBuilder.Entity<Question>().Navigation(x => x.UserAnswers).AutoInclude();
            modelBuilder.Entity<Question>().HasMany(x => x.UserAnswers).WithOne(x => x.Question).HasForeignKey(x => x.QuestionId);
          
            
            //modelBuilder.ApplyConfiguration(new FormConfigurations());
            //modelBuilder.ApplyConfiguration(new QuestionConfigurations());
            //modelBuilder.ApplyConfiguration(new AnswerConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
