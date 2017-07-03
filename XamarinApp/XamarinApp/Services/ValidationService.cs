using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Services
{
    public class ValidationService<T> : IValidationService<T>
    {
        private ValidationResult Result { get; set; }
        private readonly IValidator<T> _validator;
        private readonly IValidationServiceResult _validationServiceResult;
       
        public IValidationServiceResult validate(T model)
        {
            Result = _validator.Validate(model);
            _validationServiceResult.IsValid = Result.IsValid;
            _validationServiceResult.ErrorList = Result.Errors;
            return _validationServiceResult;
        }
    }
}
