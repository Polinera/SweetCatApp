using SweetCatApp.Models;

namespace SweetCatApp.Views;

public partial class DetailedCatView : ContentPage
{
    public DetailedCatView(Animal animal)
    {
        InitializeComponent();
        BindingContext = new AnimalViewModel(animal);
    }
}
