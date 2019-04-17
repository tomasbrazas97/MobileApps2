using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            //this.BindingContext = new SavesViewModel(new PageService());

            //Launch an instance of media player
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///backgroundMusic.mp3", UriKind.RelativeOrAbsolute));
            mediaPlayer.Volume = 0.15;
            mediaPlayer.Play();
            mediaPlayer.IsMuted = false;
        }

        //Navigation from Saves to MainPage
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //Navigation from Saves to MainMenu
        private async void Return_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
            mediaPlayer.Dispose();
        }

        //One attempt at Deserialization 
        public static void DeSerialization()
        {
            //Read object from the file
            string json = File.ReadAllText(@"C:\Users\tomas\Documents\GitHub\MobileApps2\RNGfighter\RNGfighter\Data\myPlayers.txt");

            //Deserialize the object
            Player data = JsonConvert.DeserializeObject<Player>(json);

            //Assign data
           // viewID.Text = data.ID;
        }
    }
}