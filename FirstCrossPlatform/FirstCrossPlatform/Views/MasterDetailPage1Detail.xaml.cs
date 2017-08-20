using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstCrossPlatform.Services;
using FirstCrossPlatform.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstCrossPlatform.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        ListView DetailListView;

        public MasterDetailPage1Detail()
        {
            InitializeComponent();

            BindingContext = new MenuItemViewModel();
            DetailListView = Detail1ItemsListView;
        }
    }
}