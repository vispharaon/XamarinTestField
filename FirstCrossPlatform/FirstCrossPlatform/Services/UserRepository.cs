using System.Threading.Tasks;
using FirstCrossPlatform.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace FirstCrossPlatform.Services
{
    public class UserRepository : IUserRepository
    {
        public async Task<TestPostApi> GetRequest()
        {
            var client = new HttpClient();

            var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1") ;

            return JsonConvert.DeserializeObject<TestPostApi>(response);

        }

        public bool IsUserCorrect(User user)
        {
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(user.Username, user.Password);

            //client.Credentials = credentials;
            return true;
        }
    }
}
