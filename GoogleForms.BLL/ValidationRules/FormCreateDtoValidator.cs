using FluentValidation;
using GoogleForms.DTOs;

namespace GoogleForms.BLL.ValidationRules
{
    public class FormCreateDtoValidator: AbstractValidator<FormCreateDto>
    {
        public FormCreateDtoValidator()
        {
            RuleFor(x => x.FormTitle).NotEmpty().WithMessage("Form Başlığı boş geçilemez");
            RuleFor(x => x.FormDescription).NotEmpty().WithMessage("Form Açıklaması boş geçilemez");

        }
    }
}
