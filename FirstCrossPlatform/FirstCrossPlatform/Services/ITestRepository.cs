using System.Collections.Generic;
using System.Threading.Tasks;
using FirstCrossPlatform.Models;

namespace FirstCrossPlatform.Services
{
    public interface ITestRepository
    {
        Task<IList<Test>> GetRequest();
    }
}
