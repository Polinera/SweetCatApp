using SweetCatApp.Models;
using System.Windows.Input;

namespace SweetCatApp.Views;

public partial class PetsProfilView : ContentPage
{
	public PetsProfilView()
	{
		InitializeComponent();
		BindingContext = new PetsProfilViewModel();
	}
    
}