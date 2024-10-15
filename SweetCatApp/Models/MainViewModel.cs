using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SweetCatApp.Models
{
    public class MainViewModel
    {
        public ICommand NavigateToClalculator { get; }
        public ICommand NavigateToPetProfiles { get; }
        public ICommand NavigateToRaces { get; }
        public MainViewModel()
        {
            NavigateToPetProfiles = new Command(async () => await GoToPetProfilesView());
            NavigateToRaces = new Command(async () => await GoToCatsDictionaryView());
        }

        private async Task GoToPetProfilesView()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.PetsProfilView());
        }
        private async Task GoToCatsDictionaryView()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.CatsDictionaryView());
        }
    }
}
