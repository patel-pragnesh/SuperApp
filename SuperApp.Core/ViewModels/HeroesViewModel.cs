using System;
using System.Windows.Input;
using Robjects.Core.Input;
using Robjects.Core.ViewModels;

namespace SuperApp.Core.ViewModels
{
    public class HeroesViewModel : BaseNavigationViewModel
    {
        ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new Command(async () => await Navigation.PushModalAsync(new HeroViewModel()));
                }

                return _addCommand;
            }
        }

        ICommand _editCommand;
        public ICommand EditCommand
        {
            get
            {
                if (_editCommand == null)
                {
                    _editCommand = new Command(async () => await Navigation.PushAsync(new HeroViewModel()));
                }

                return _editCommand;
            }
        }

        public HeroesViewModel()
        { }
    }
}
