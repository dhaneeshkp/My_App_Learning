using Autofac;
using CoreProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreProject.Factories
{
    public class ViewFactory : IViewFactory
    {
        private readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();
        private readonly IComponentContext _componentContext;

        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
            Instance = this;
        }
        public static IViewFactory Instance { get; private set; }
        public void Register<TViewModel, TView>() where TViewModel : class, IViewModel where TView : Page
        {
            _map[typeof(TViewModel)] = typeof(TView);
        }

        public Page Resolve<TViewModel>(TViewModel viewmodel) where TViewModel : class, IViewModel
        {
            var type = viewmodel.GetType();
            var viewType = _map[type];
            var view = _componentContext.Resolve(viewType) as Page;
            view.BindingContext = viewmodel;
            return view;
        }

        public Page Resolve<TViewModel>(Action<TViewModel> setStateAction) where TViewModel : class, IViewModel
        {
            TViewModel viewmModel;
            return Resolve<TViewModel>(out viewmModel, setStateAction);
        }

        public Page Resolve<TViewModel>(out TViewModel viewmodel, Action<TViewModel> setStateAction) where TViewModel : class, IViewModel
        {
            viewmodel = _componentContext.Resolve<TViewModel>();
            var viewType = _map[typeof(TViewModel)];
            var view = _componentContext.Resolve(viewType) as Page;
            if (setStateAction != null) setStateAction(viewmodel);
            view.BindingContext = viewmodel;
            return view;
        }
    }
}
