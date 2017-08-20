namespace FirstCrossPlatform.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new FirstCrossPlatform.App());
        }
    }
}