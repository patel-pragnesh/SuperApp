using System;
using System.Collections.Generic;
using System.Windows.Input;
using Robjects.Core.Input;
using Robjects.Core.ViewModels;

namespace SuperApp.Core.ViewModels
{
    public class MenuViewModel : BaseNavigationViewModel
    {
        public IList<string> MenuItems { get; set; }

        ICommand _menuItemSelectedCommand;
        public ICommand MenutItemSelectedCommand
        {
            get
            {
                if (_menuItemSelectedCommand == null)
                {
                    _menuItemSelectedCommand = new Command<string>(OnMenuItemSelected);
                }

                return _menuItemSelectedCommand;
            }
        }

        public MenuViewModel() => LoadMenuItems();

        void LoadMenuItems()
        {
            MenuItems = new List<string>
            {
                "Heroes",
                "Skills"
            };
        }

        async void OnMenuItemSelected(string item)
        {


            switch (item)
            {
                case "Heroes":
                    SetDetailViewModel(new HeroesViewModel());
                    break;
                case "Skills":
                    SetDetailViewModel(new SkillsViewModel());
                    break;
            }
        }

        void SetDetailViewModel(BaseNavigationViewModel vm) => Navigation.ReplaceAsync(vm);
    }
}
