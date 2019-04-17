using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Media.Playback;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RNGfighter
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Saves : ContentPage
	{
        private MediaPlayer mediaPlayer;

        public Saves ()
		{
			InitializeComponent ();

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

        private async void Return_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
            mediaPlayer.Dispose();
        }
    }
}