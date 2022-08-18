using FluentValidation;
using GoogleForms.DTOs;

namespace GoogleForms.BLL.ValidationRules
{
    public class FormUpdateDtoValidator:AbstractValidator<FormUpdateDto>
    {
        public FormUpdateDtoValidator()
        {

        }
    }
}
