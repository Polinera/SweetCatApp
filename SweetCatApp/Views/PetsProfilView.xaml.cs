using SweetCatApp.Models;

namespace SweetCatApp.Views;

public partial class PetsProfilView : ContentPage
{
	public PetsProfilView()
	{
		InitializeComponent();
		BindingContext = new PetsProfilViewModel();
	}
}