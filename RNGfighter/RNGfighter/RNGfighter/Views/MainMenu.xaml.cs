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
		public MainMenu()
		{
			InitializeComponent();
            mainBanner.Source = ImageSource.FromFile("mainbanner.png");

            var mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///backgroundMusic.mp3", UriKind.RelativeOrAbsolute));
            mediaPlayer.Volume = 0.15;
            mediaPlayer.Play();
            mediaPlayer.IsMuted = false;
        }


        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        
    }

    
}