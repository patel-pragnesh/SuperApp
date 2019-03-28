using System;
using System.Threading.Tasks;
using Robjects.Core.ViewModels;

namespace Robjects.Core.Services
{
    public interface INavigationService
    {
        void RegisterViewModels(System.Reflection.Assembly asm);
        void Register(Type viewModelType, Type viewType);

        Task PopAsync();
        Task PopModalAsync();
        Task PushAsync(BaseNavigationViewModel viewModel);
        Task PushAsync<T>(Action<T> initialize = null) where T : BaseNavigationViewModel;
        Task PushModalAsync<T>(Action<T> initialize = null) where T : BaseNavigationViewModel;
        Task PushModalAsync(BaseNavigationViewModel viewModel);
        Task PopToRootAsync(bool animate);

        Task ReplaceAsync<T>(Action<T> initialize = null) where T : BaseNavigationViewModel;
        Task ReplaceAsync(BaseNavigationViewModel viewModel, bool allowSamePageSet = false);

        void ReplaceRoot(BaseNavigationViewModel viewModel, bool withNavigationEnabled = true);
    }
}
