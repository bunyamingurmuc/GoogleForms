using FluentValidation;
using GoogleForms.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.ValidationRules
{
    public class UserAnswerCreateDtoValidator:AbstractValidator<UserAnswerCreateDto>
    {
        public UserAnswerCreateDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
