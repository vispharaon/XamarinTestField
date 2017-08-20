using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FirstCrossPlatform.Models;
using FirstCrossPlatform.Services;
using FirstCrossPlatform.Views;

namespace FirstCrossPlatform.ViewModels
{
    public class MenuItemViewModel : BaseViewModel
    {
        readonly ITestRepository _testRepository = new TestRepositoy();
        public List<Test> Tests;
        public ObservableCollection<Test> TestItems { get; set; }

        public MenuItemViewModel()
        {
            Tests = _testRepository.GetRequest().Result.ToList();

            foreach (var test in Tests)
            {
                TestItems.Add(new Test
                {
                    Id = test.Id,
                    IsOk = test.IsOk,
                    Name = test.Name
                });
            }
        }
    }
}
