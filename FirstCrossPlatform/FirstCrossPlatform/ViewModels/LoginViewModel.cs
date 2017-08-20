using FirstCrossPlatform.Models;
using FirstCrossPlatform.Services;
using Xamarin.Forms;

namespace FirstCrossPlatform.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        IUserRepository userTest = new UserRepository();
        public Command TestGetAsync;
        public User User;

        public LoginViewModel()
        {
            Title = "Login";

            User = new User();
            //TestGetAsync = new Command(async () => await userTest.GetRequest());


        }

        public bool IsUserCorrect()
        {
            //Currently not implemented
            //return userTest.IsUserCorrect(User);
            return User.Username != null && User.Password != null;
        }



    }
}
