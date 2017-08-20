using FirstCrossPlatform.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FirstCrossPlatform
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static bool IsLogged { get; set; }

        public static void SetMainPage()
        {
            if (IsLogged)
                Current.MainPage = new MasterDetailPage1();
            else
                Current.MainPage = new LoginPage();
            //Current.MainPage =  new NavigationPage(new LoginPage()); ;
            //Current.MainPage = new TabbedPage
            //{
            //    Children =
            //    {
            //        new NavigationPage(new ItemsPage())
            //        {
            //            Title = "Browse",
            //            Icon = Device.OnPlatform("tab_feed.png",null,null)
            //        },
            //        new NavigationPage(new AboutPage())
            //        {
            //            Title = "About",
            //            Icon = Device.OnPlatform("tab_about.png",null,null)
            //        },
            //    }
            //};
        }
    }
}
