using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Media.Playback;
using Xamarin.Forms;

namespace RNGfighter
{
    public partial class MainPage : ContentPage
    {
        static string damage = new Random().Next(1, 4).ToString();
        public MediaPlayer mediaPlayer;

        public MainPage()
        {
            InitializeComponent();
            enemyImage.Source = ImageSource.FromFile("redDragon.jpg");
            fireImage.Source = ImageSource.FromFile("fireBG.jpg");

            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///backgroundMusic.mp3", UriKind.RelativeOrAbsolute));
            mediaPlayer.Volume = 0.15;
            mediaPlayer.Play();
            mediaPlayer.IsMuted = false;
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

        public void Mute_OnClicked(object sender, EventArgs e)
        {

            if (mediaPlayer.IsMuted == false)
            {
                mediaPlayer.IsMuted = true;
                muteBtn.Text = "Unmute";
            }
            else
            {
                mediaPlayer.IsMuted = false;
                muteBtn.Text = "Mute";
            }
        }
    }
}
