using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using Utils;

namespace RNGfighter
{
    public class Player
    {
        public string ID { get; set; }
        public string Time { get; set; }
        public string Score { get; set; }
    }

    public class PlayerList
    {
        public List<Player> players { get; set; }
    }
}
