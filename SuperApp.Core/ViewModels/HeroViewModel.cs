using System.Threading.Tasks;
using System.Windows.Input;
using Robjects.Core.Input;
using Robjects.Core.ViewModels;

namespace SuperApp.Core.ViewModels
{
    public class HeroViewModel : BaseNavigationViewModel
    {
        ICommand _saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new Command(async () => await Save());
                }

                return _saveCommand;
            }
        }

        ICommand _cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new Command(async() => await Dismiss());
                }

                return _cancelCommand;
            }
        }

        public HeroViewModel()
        { }

        async Task Save()
        {
            // TODO: Save the thaangs

            // This isn't just returned as a Task from this method, because of other functionality to come
            await Dismiss();
        }
    }
}
