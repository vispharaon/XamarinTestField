using FirstCrossPlatform.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FirstCrossPlatform.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //public string Username { get; set; }
        //public string Password { get; set; }
        public LoginViewModel viewModel;

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginViewModel();
        }

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            //test async call
            //viewModel.TestGetAsync.Execute(null);
            if(!viewModel.IsUserCorrect())
                await DisplayAlert("Login message", "Credentials incorrect", "OK");
            else
            {
                App.IsLogged = true;
                App.SetMainPage();
            }
                //await Navigation.PushAsync(new MasterDetailPage1());

        }
        
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.User.Username = ((Entry)sender).Text;
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            viewModel.User.Password = ((Entry)sender).Text;
        }
    }
}