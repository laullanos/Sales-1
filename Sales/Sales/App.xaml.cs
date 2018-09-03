using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Sales
{
    using Helpers;
    using Views;
    using ViewModels;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.IsRemembered)
            {
                MainViewModel.GetInstance().Products = new ProductsViewModel();
                this.MainPage = new NavigationPage(new ProductsPage());
            }
            else
            {
                MainViewModel.GetInstance().Login = new LoginViewModel();
                this.MainPage = new LoginPage();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
