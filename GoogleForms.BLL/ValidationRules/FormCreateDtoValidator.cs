using FluentValidation;
using GoogleForms.DTOs;

namespace GoogleForms.BLL.ValidationRules
{
    public class FormCreateDtoValidator: AbstractValidator<FormCreateDto>
    {
        public FormCreateDtoValidator()
        {
        }
    }
}
