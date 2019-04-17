using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Utils;
using Xamarin.Forms;
/*
namespace RNGfighter
{
    public class SavesViewModel : BaseViewModel
    {
        #region == private fields ==
        private ObservableCollection<PlayerViewModel> playerList;
        private PlayerViewModel selectedPlayer;
        #endregion

        #region == Public Properties ==
        public ObservableCollection<PlayerViewModel> PlayerList
        {
            get { return playerList; }
            set { SetValue(ref playerList, value); }
        }
        public PlayerViewModel SelectedPlayer
        {
            get { return selectedPlayer; }
            set
            {
                SetValue(ref selectedPlayer, value);

            }
        }
        #endregion

        #region == Command Properties ==
        // ICommand is an interface with two methods
        // can execute and execute
        public ICommand ReadListCommand { get; private set; }
        public ICommand SaveListCommand { get; private set; }
        public ICommand DeleteFromListCommand { get; private set; }
        #endregion

        #region == public events ==
        private readonly IPageService _pageService;
        public PlayerViewModel(IPageService pageService)
        {
            _pageService = pageService;
            ReadList();
            ReadListCommand = new Command(ReadList);
            SaveListCommand = new Command(SaveList);
            DeleteFromListCommand = new Command<PlayerViewModel>(DeleteFromList);
        }

        private void SaveList()
        {
            PlayerViewModel.SavePlayerListData(PlayerList);
        }

        private void ReadList()
        {
            PlayerList = PlayerViewModel.ReadPlayerListData();
        }

        private void DeleteFromList(PlayerViewModel d)
        {
            PlayerList.Remove(d);
            SelectedPlayer = null;
        }

        

        #endregion
    }
}*/