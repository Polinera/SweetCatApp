using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace SweetCatApp.Models
{
    public class CatsDictionaryViewModel
    {
        public ICommand NavigateToBengalView { get; }
        public ICommand NavigateToMaineCoonView { get; }
        public ICommand NavigateToBritishShorthairView { get; }

        public ICommand NavigateToMain { get; }

        public CatsDictionaryViewModel()
        {
            NavigateToMain = new Command(async () => await GoToMainView());
            NavigateToBengalView = new Command(async () => await GoToBengalView());
            NavigateToMaineCoonView = new Command(async () => await GoToMainecoonView());
            NavigateToBritishShorthairView = new Command(async () => await GoToBrithisView());
        }
        private string LoadDescriptionFromFile(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"SweetCatApp.Resources.Assets.{fileName}";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        private async Task GoToBengalView()
        {
            var bengalDescription = LoadDescriptionFromFile("bengal_description.txt");
            var bengalCat = new Animal()
            {
                Name = Resources.Strings.Bengal_Text_Label,
                Image = "bengal_image.png",
                Description = bengalDescription
            };

            await Application.Current.MainPage.Navigation.PushAsync(new Views.DetailedCatView(bengalCat));
        }
        private async Task GoToMainecoonView()
        {
            var bengalDescription = LoadDescriptionFromFile("mainecoon_description.txt");
            var mainecoonCat = new Animal()
            {
                Name = Resources.Strings.Mainecoon_Text_Label,
                Image = "mainecoon_image.png",
                Description = bengalDescription
            };
            await Application.Current.MainPage.Navigation.PushAsync(new Views.DetailedCatView(mainecoonCat));
        }
        private async Task GoToBrithisView()
        {
            var britishDescription = LoadDescriptionFromFile("brithis_description.txt");

            var britishCat = new Animal()
            {
                Name = Resources.Strings.Brithis_Blue_Text_Label,
                Image = "brithis_blue_image.png",
                Description = britishDescription
            };
            await Application.Current.MainPage.Navigation.PushAsync(new Views.DetailedCatView(britishCat));
        }

        private async Task GoToMainView()
        {
           
            await Application.Current.MainPage.Navigation.PushAsync(new Views.PetsProfilView());
        }
    }
}