using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FirstCrossPlatform.Models;
using Newtonsoft.Json;

namespace FirstCrossPlatform.Services
{
    public class TestRepositoy : ITestRepository
    {
        public async Task<IList<Test>> GetRequest()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("http://localhost:56501/api/tests");

            return JsonConvert.DeserializeObject<IEnumerable<Test>>(response).ToList();
        }
    }
}