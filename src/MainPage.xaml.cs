using System.Runtime.InteropServices.ObjectiveC;

namespace MauiCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NumButton_Pressed(object sender, EventArgs e)
        {
            if (ResultLabel.Text == "0") ResultLabel.Text = string.Empty;

            Button numBtn = (Button)sender;
            ResultLabel.Text += numBtn.Text;
        }

        private async void OpButton_Pressed(object sender, EventArgs e)
        {
            if (ResultLabel.Text == "0")
            {
                await DisplayAlert("Error", "Cannot type operator when cleared", "Ok");
            }
            else
            {
                Button numBtn = (Button)sender;
                ResultLabel.Text += numBtn.Text;
            }
        }

        private void Backspace_Pressed(object sender, EventArgs e)
        {
            string original = ResultLabel.Text;
            if (original.Length == 0 || original == "0") ResultLabel.Text = "0";
            else
            {
                ResultLabel.Text = original.Substring(0, original.Length - 1);
                if (ResultLabel.Text.Length == 0) ResultLabel.Text = "0";
            }
        }

        private void Comma_Pressed(object sender, EventArgs e)
        {
            ResultLabel.Text += ".";
        }

        private void Equals_Pressed(object sender, EventArgs e)
        {
        }

        private void CE_Pressed(object sender, EventArgs e)
        {
            ExpressionLabel.Text = "0";
        }

        private void C_Pressed(object sender, EventArgs e)
        {
            ExpressionLabel.Text = "0";
            ResultLabel.Text = "0";
        }
    }
}