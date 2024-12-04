using SweetCatApp.Models;
using System.Windows.Input;
using SweetCatApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SweetCatApp.Models
{
    class AddPetProfileViewModel : ContentPage
    {
        public AddPetProfileViewModel()
        {
            Items = new ObservableCollection<string>
        {
            "Kobieta",
            "Mężczyzna"
        };
            _selectedItem = Preferences.Get("SelectedItem", null);
        }

        public ObservableCollection<string> Items { get; set; }

        private string _selectedItem;
        public string SelectedItem
        {
            get => Preferences.Get("SelectedItem", null);
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    Preferences.Set("SelectedItem", value);
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
