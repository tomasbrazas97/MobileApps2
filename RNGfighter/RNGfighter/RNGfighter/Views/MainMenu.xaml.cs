using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.Media.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RNGfighter
{
	public partial class MainMenu : ContentPage
	{
        public MediaPlayer mediaPlayer;

        public MainMenu()
		{
			InitializeComponent();
            mainBanner.Source = ImageSource.FromFile("mainbanner.png");

            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///backgroundMusic.mp3", UriKind.RelativeOrAbsolute));
            mediaPlayer.Volume = 0.15;
            mediaPlayer.Play();
            mediaPlayer.IsMuted = false;
        }


        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void LoadGame_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Saves());
            mediaPlayer.Dispose();
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