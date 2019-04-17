using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Utils;
/*
namespace PlayerViewModel
{
    public class DogsViewModel : BaseViewModel
    {
        #region == Public Properties ==
        public string Breed { get; set; }
        private string _origin;
        public string Origin
        {
            get { return _origin; }
            set { SetValue(ref _origin, value); }
        }
        private string _size;
        public string Size
        {
            get { return _size; }
            set { SetValue(ref _size, value); }
        }
        public string Grooming { get; set; }
        public string Exercise { get; set; }
        public string Temperament { get; set; }

        #endregion


        #region == Methods ==
        public static ObservableCollection<DogsViewModel> ReadDogListData()
        {
            ObservableCollection<PlayerViewModel> myList = new ObservableCollection<PlayerViewModel>();
            string jsonText;

            try  // reading the localApplicationFolder first
            {
                string path = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, MyUtils.JSON_PLAYERS_FILE);
                using (var reader = new StreamReader(filename))
                {
                    jsonText = reader.ReadToEnd();
                    // need json library
                }
            }
           catch // fallback is to read the default file
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(
                                                typeof(MainPage)).Assembly;
                // create the stream
                Stream stream = assembly.GetManifestResourceStream(
                                    "ListView1.Data.myDogs.txt");
                using (var reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                    // include JSON library now
                }
            }

            myList = JsonConvert.DeserializeObject<ObservableCollection<DogsViewModel>>(jsonText);

            return myList;
        }

        public static void SavePlayersListData(ObservableCollection<PlayersViewModel> saveList)
        {
            // need the path to the file
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, MyUtils.JSON_PLAYERS_FILE);
            // use a stream writer to write the list
            using (var writer = new StreamWriter(filename, false))
            {
                // stringify equivalent
                string jsonText = JsonConvert.SerializeObject(saveList);
                writer.WriteLine(jsonText);
            }
        }

        #endregion

    }
}
*/