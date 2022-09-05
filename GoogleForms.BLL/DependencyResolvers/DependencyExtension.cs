using FluentValidation;
using GoogleForms.BLL.Interfaces;
using GoogleForms.BLL.Services;
using GoogleForms.BLL.ValidationRules;
using GoogleForms.DAL.Context;
using GoogleForms.DAL.UnitOfWork;
using GoogleForms.DTOs;
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
