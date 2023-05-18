namespace MauiCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void Shell_Loaded(object sender, EventArgs e)
        {
            await DisplayAlert("Important information", "This app runs on a pre-release version of .NET 8. Be careful!", "I got it");
        }
    }
}