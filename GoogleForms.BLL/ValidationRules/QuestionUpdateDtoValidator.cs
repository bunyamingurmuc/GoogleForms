using FluentValidation;
using GoogleForms.DTOs;

namespace GoogleForms.BLL.ValidationRules
{
    public class QuestionUpdateDtoValidator : AbstractValidator<QuestionUpdateDto>
    {
        public QuestionUpdateDtoValidator()
        {

        }
    }
}
