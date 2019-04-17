using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RNGfighter
{
    public partial class MainPage : ContentPage
    {
        static string damage = new Random().Next(1, 4).ToString();

        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //Taking damage
            if (button.Text == damage)
            {
                await DisplayAlert("You took Damage", "Time has been deducted.", "Continue");
                damage = new Random().Next(1, 4).ToString();
            }
        }
    }
}
