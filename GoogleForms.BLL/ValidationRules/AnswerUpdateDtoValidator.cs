using FluentValidation;
using GoogleForms.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.ValidationRules
{
    public class AnswerUpdateDtoValidator: AbstractValidator<AnswerUpdateDto>
    {
        public AnswerUpdateDtoValidator()
        {

        }
    }
}
