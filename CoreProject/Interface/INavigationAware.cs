using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Interface
{
 public   interface INavigationAware
    {
        void NavigatedTo();
        void NavigatedFrom();
    }
}
