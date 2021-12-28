using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using hypixelstats.Model;
using Xamarin.Forms;
using Xamarin.Essentials;
using hypixelstats.Services;

namespace hypixelstats.ViewModel
{
    public class SearchResultViewModel: INotifyPropertyChanged
    {
        IAPICaller apiCaller = DependencyService.Get<IAPICaller>();
        public event PropertyChangedEventHandler PropertyChanged;
        private Player player;
        private string searchFieldContent;

        public Player Player
        {
            get { return player; }
            set
            {
                player = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player"));
            }
        }

        public string SearchFieldContent
        {
            get { return searchFieldContent; }
            set { searchFieldContent = value; }
        }

        public async void GetPlayer()
        {
            this.Player = await apiCaller.GetPlayer(searchFieldContent);
        }
    }
}
