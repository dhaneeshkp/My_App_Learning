using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Interface
{
    public interface INavigator
    {
        Task<IViewModel> PopAsync();
        Task<IViewModel> PopModelAsync();
        Task<IViewModel> PopToRootAsync();
        Task<TViewModel> PushAsync<TViewModel>(Action<TViewModel> setStateAction = null) where TViewModel : class, IViewModel;
        TViewModel PushAsyncmasterDetailsPage<TViewModel>(Action<TViewModel> setStateAction = null) where TViewModel : class, IViewModel;
        Task<TViewModel> PushAsync<TViewModel>(TViewModel viewModel) where TViewModel : class, IViewModel;
        Task<TViewModel> PushModelAsync<TViewModel>(Action<TViewModel> setStateAction = null) where TViewModel : class, IViewModel;
        Task<TViewModel> PushModelAsync<TViewModel>(TViewModel viewModel) where TViewModel : class, IViewModel;

    }
}
