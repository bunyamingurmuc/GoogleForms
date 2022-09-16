using FluentValidation;
using GoogleForms.BLL.CustomDescriber;
using GoogleForms.BLL.Interfaces;
using GoogleForms.BLL.Services;
using GoogleForms.BLL.ValidationRules;
using GoogleForms.DAL.Context;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs;
using GoogleForms.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoogleForms.BLL.DependencyResolvers
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GoogleFormsContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });
            services.AddIdentity<AppUser,AppRole>(o=>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequiredLength = 1;
                
             
            }).AddErrorDescriber<CustomErrorDescriber>().AddEntityFrameworkStores<GoogleFormsContext>();

            services.ConfigureApplicationCookie(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                o.Cookie.Name = "FormCookie";
                o.ExpireTimeSpan= TimeSpan.FromDays(1);
                o.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/form/accessdenied");
                o.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                
            });
            services.AddScoped<IUOW, UOW>();
            services.AddScoped<IFormService, FormService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IAnswerService, AnswerService>();


            services.AddSingleton<IValidator<FormCreateDto>, FormCreateDtoValidator>();
            services.AddSingleton<IValidator<FormUpdateDto>, FormUpdateDtoValidator>();
            services.AddSingleton<IValidator<QuestionCreateDto>, QuestionCreateDtoValidator>();
            services.AddSingleton<IValidator<QuestionUpdateDto>, QuestionUpdateDtoValidator>();
            services.AddSingleton<IValidator<AnswerCreateDto>, AnswerCreateDtoValidator>();
            services.AddSingleton<IValidator<AnswerUpdateDto>, AnswerUpdateDtoValidator>();
            services.AddSingleton<IValidator<UserAnswerCreateDto>, UserAnswerCreateDtoValidator>();


        }
    }
}
