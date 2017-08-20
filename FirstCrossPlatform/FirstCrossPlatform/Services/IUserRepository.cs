using FirstCrossPlatform.Models;
using System.Threading.Tasks;

namespace FirstCrossPlatform.Services
{
    public interface IUserRepository
    {
        //Task<User> GetUserByUsernameAndPasswordAsync(string username, string password);
        Task<TestPostApi> GetRequest();
        bool IsUserCorrect(User user);

    }
}
