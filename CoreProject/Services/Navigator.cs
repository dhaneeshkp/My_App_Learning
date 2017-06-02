using CoreProject.Factories;
using CoreProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoreProject.Services
{
    public class Navigator : INavigator
    {
        private readonly IPage _page;
        private readonly IViewFactory _viewFactory;

        public Navigator(IPage page, IViewFactory viewFactory)
        {
            _page = page;
            _viewFactory = viewFactory;
        }
        private INavigation Navigation
        {
            get { return _page.Navigation; }
        }
        public async Task<IViewModel> PopAsync()
        {
            Page view = await Navigation.PopAsync();
            var viewModel = view.BindingContext as IViewModel;
            viewModel.NavigatedFrom();
            return viewModel;
        }
       

        public async Task<IViewModel> PopModelAsync()
        {
            Page view = await Navigation.PopModalAsync();
            var viewModel = view.BindingContext as IViewModel;
            viewModel.NavigatedFrom();
            return viewModel;
        }

        public async Task PopToRootAsync()
        {
            await Navigation.PopToRootAsync();

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
