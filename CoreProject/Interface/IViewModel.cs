using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Interface
{
    public interface IViewModel : INotifyPropertyChanged, INavigationAware
    {
        string Title { get; set; }
    }
}
