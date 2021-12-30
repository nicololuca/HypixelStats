using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Windows.Input;
using hypixelstats.Model;
using hypixelstats.Services;

namespace hypixelstats.ViewModel
{
    public class SearchResultViewModel : INotifyPropertyChanged
    {
        IAPICaller apiCaller = DependencyService.Get<IAPICaller>();

        public event PropertyChangedEventHandler PropertyChanged;

        private Player player;
        private string searchFieldContent;
        private bool isLoading = false;
        private bool areResultsShown = false;

        public ICommand getPlayer { get; }

        public SearchResultViewModel()
        {
            getPlayer = new Command(GetPlayer);
        }

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
            set
            {
                searchFieldContent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SearchFieldContent"));
            }
        }

        public bool AreResultsShown
        {
            get { return areResultsShown; }
            set
            {
                areResultsShown = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AreResultsShown"));
            }
        }

        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                isLoading = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLoading"));
                AreResultsShown = !value;
            }
        }

        public async void GetPlayer() {
            if (SearchFieldContent != "")
            {
                IsLoading = true;
                Console.WriteLine("SearchViewModel - Chiamata GetPlayer()");
                Console.WriteLine($"SearchViewModel - Casella di testo: {searchFieldContent}");
                Player = await apiCaller.GetPlayer(searchFieldContent);
                Console.WriteLine("SearchViewModel - Testing Player property");
                Console.WriteLine($"Player rank: {Player.rank}");
                Console.WriteLine($"Player displayname: {Player.username}");
                IsLoading = false;
            }
        }
    }
}
