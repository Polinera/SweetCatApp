using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SweetCatApp.Models
{
    public class PetsProfilViewModel
    {
        public ICommand NavigateToAddPetProfiles { get; }
        public ICommand NavigateToEditPetProfiles { get; }

        public PetsProfilViewModel()
        {
            NavigateToAddPetProfiles = new Command(async () => await GoToAddPetProfilesView());
            NavigateToEditPetProfiles = new Command(async () => await GoToEditPetProfilesView());

        }

        private async Task GoToAddPetProfilesView()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.AddPetProfileView());
        }
        private async Task GoToEditPetProfilesView()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.EditPetProfileView());
        }
    }
}
