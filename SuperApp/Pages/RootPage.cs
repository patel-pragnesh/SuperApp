using SuperApp.Core.ViewModels;
using Xamarin.Forms;

namespace SuperApp.Pages
{
    public class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            Master = new MenuPage
            {
                ViewModel = new MenuViewModel()
            };

            var heroesPage = new HeroesPage
            {
                ViewModel = new HeroesViewModel()
            };

            Detail = new NavigationPage(heroesPage);
        }
    }
}

