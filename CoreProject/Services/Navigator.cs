using CoreProject.Factories;
using CoreProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Services
{
    public class Navigator : INavigator
    {
        private readonly IPage _page;
        private readonly IViewFactory _viewFactory;

        public Navigator(IPage page,IViewFactory viewFactory)
        {
            _page = page;
            _viewFactory = viewFactory;
        }
        public Task<IViewModel> PopAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IViewModel> PopModelAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IViewModel> PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        Task<TViewModel> INavigator.PushAsync<TViewModel>(TViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        Task<TViewModel> INavigator.PushAsync<TViewModel>(Action<TViewModel> setStateAction)
        {
            throw new NotImplementedException();
        }

        TViewModel INavigator.PushAsyncmasterDetailsPage<TViewModel>(Action<TViewModel> setStateAction)
        {
            throw new NotImplementedException();
        }

        Task<TViewModel> INavigator.PushModelAsync<TViewModel>(TViewModel viewModel)
        {
            throw new NotImplementedException();  
        }

        Task<TViewModel> INavigator.PushModelAsync<TViewModel>(Action<TViewModel> setStateAction)
        {
            throw new NotImplementedException();
        }
    }
}
