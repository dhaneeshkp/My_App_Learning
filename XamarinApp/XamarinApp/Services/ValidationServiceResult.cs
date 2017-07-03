using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace XamarinApp.Services
{
    public class ValidationServiceResult : IValidationServiceResult
    {
        public IList<ValidationFailure> ErrorList
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsValid
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void ShowNotificationError()
        {
            throw new NotImplementedException();
        }

        public void Thend(Action success = null, Action failure = null)
        {
            throw new NotImplementedException();
        }
    }
}
