using FluentValidation;
using GoogleForms.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.ValidationRules
{
    public class AnswerCreateDtoValidator:AbstractValidator<AnswerCreateDto>
    {
        public AnswerCreateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Cevap alanı boş geçilemez");
        }
    }
}
