using SweetCatApp.Models;

namespace SweetCatApp.Views;

public partial class AddPetProfileView : ContentPage
{
	public AddPetProfileView()
	{
		InitializeComponent();
        BindingContext = new AddPetProfileViewModel(); 
	}
}