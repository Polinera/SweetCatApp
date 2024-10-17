using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SweetCatApp.Models
{
    public class AnimalViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string _image;
        private string _description;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        // Command for navigating to the animal's profile view
        public ICommand NavigateToMainCommand { get; }

        // Constructor that accepts an Animal object and populates the ViewModel properties
        public AnimalViewModel(Animal animal)
        {
            Name = animal.Name;
            Image = animal.Image;
            Description = animal.Description;

            // Initialize the command
            NavigateToMainCommand = new Command(async () => await GoToMainView());
        }

        // Method for navigating to the PetsProfilView
        private async Task GoToMainView()
        {
            // You can pass the current animal details if needed
            await Application.Current.MainPage.Navigation.PushAsync(new Views.PetsProfilView());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}