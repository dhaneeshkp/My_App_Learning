using CoreProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreProject.Factories
{
  public   interface IViewFactory
    {
        void Register<TViewModel, TView>() where TViewModel : class, IViewModel where TView : Page;
        Page Resolve<TViewModel>(Action<TViewModel> setStateAction = null) where TViewModel : class,IViewModel;
        Page Resolve<TViewModel>(out TViewModel viewmodel, Action<TViewModel> setStateAction = null) where TViewModel : class, IViewModel;
        Page Resolve<TViewModel>(TViewModel viemodel) where TViewModel : class, IViewModel;

    }
}
