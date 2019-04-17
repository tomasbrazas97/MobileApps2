using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Windows.Media.Core;
using Windows.Media.Playback;
using Xamarin.Forms;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace RNGfighter
{
    public partial class MainPage : ContentPage
    {
        static string damage = new Random().Next(1, 4).ToString();
        int score = 1;
        public MediaPlayer mediaPlayer;
        Stopwatch stopwatch;
        private object listviewPlayers;

        public MainPage()
        {
            InitializeComponent();
            //Imaghes
            enemyImage.Source = ImageSource.FromFile("redDragon.jpg");
            fireImage.Source = ImageSource.FromFile("fireBG.jpg");

            //Launch an instance of media player
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///backgroundMusic.mp3", UriKind.RelativeOrAbsolute));
            mediaPlayer.Volume = 0.15;
            mediaPlayer.Play();
            mediaPlayer.IsMuted = false;

            //Launch an instance of stopwatch
            stopwatch = new Stopwatch();
            lblStopwatch.Text = "00:00:00.00000";
            
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //Taking damage
            if (button.Text == damage)
            {
                //Adds +1 to the score
                lblScore.Text = "Score: " + score;
                score += 1;
                //Display when successful hit is registered
                await DisplayAlert("You Hit the dragon!", "Point has been obtained.", "Continue");
               
                //Randomize the numbers
                damage = new Random().Next(1, 4).ToString();
                
            }
        }

        //Mute functionality
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
        // Stopwatch functionality begins upon button click
        private void btnStart_Clicked(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();

                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    //Stopwatch is constantly updated to label
                    lblStopwatch.Text = stopwatch.Elapsed.ToString();

                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                );
            }

        }

        

    }
}
