using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Services
{
    public interface IValidationServiceResult
    {
        bool IsValid { get; set; }
        IList<ValidationFailure> ErrorList { get; set; }
        void Thend(Action success = null, Action failure = null);
        void ShowNotificationError();
    }
}
