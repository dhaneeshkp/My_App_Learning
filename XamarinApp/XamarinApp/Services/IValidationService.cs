using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp.Services
{
 public   interface IValidationService<in T>
    {
        IValidationServiceResult validate(T model);
    }
}
