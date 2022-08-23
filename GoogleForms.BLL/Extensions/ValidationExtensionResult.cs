using Buyfilet.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Extensions
{
    public static class ValidationExtensionResult
    {
        public static List<CustomValidationError> ConvertToCustomValidationError(this FluentValidation.Results.ValidationResult validationResult)
        {
            List<CustomValidationError> errors= new();
            foreach (var error in validationResult.Errors)
            {
                errors.Add(new()
                {
                    ErrorMessage = error.ErrorMessage,
                    PropertyName = error.PropertyName,
                });
            }
            return errors;
        }
    }
}
