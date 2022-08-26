using FluentValidation;
using GoogleForms.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.ValidationRules
{
    public class QuestionCreateDtoValidator : AbstractValidator<QuestionCreateDto>
    {
        public QuestionCreateDtoValidator()
        {
            RuleFor(x => x.QuestionTitle).NotEmpty().WithMessage("Soru Başlığı boş geçilemez");
            
        }
    }
}
