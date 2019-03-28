using Robjects.Core.Forms.Services;
using SuperApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SuperApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegisterServices();

            MainPage = new RootPage();
        }

        void RegisterServices()
        {
            NavigationService.Initialize(typeof(HeroesPage).Assembly);
        }
    }
}
