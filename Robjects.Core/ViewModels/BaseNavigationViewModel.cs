using System.Threading.Tasks;
using Robjects.Core.Enumerations;
using Robjects.Core.Services;
using UserProfileDemo.Core;

namespace Robjects.Core.ViewModels
{
    public abstract class BaseNavigationViewModel : BaseViewModel
    {
        public ViewModelDisplay Display { get; set; } = ViewModelDisplay.Default;

        INavigationService _navigationService;

        protected INavigationService Navigation
        {
            get
            {
                if (_navigationService == null)
                    _navigationService = ServiceContainer.Resolve<INavigationService>();

                return _navigationService;
            }
        }

        public virtual Task Dismiss()
        {
            Task task;

            if (Display == ViewModelDisplay.Modal)
                task = Navigation.PopModalAsync();
            else
                task = Navigation.PopAsync();

            return task;
        }
    }
}
