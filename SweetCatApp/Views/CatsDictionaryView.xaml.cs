using SweetCatApp.Models;

namespace SweetCatApp.Views;

public partial class CatsDictionaryView : ContentPage
{
	public CatsDictionaryView()
	{
		InitializeComponent();
		BindingContext = new CatsDictionaryViewModel();
	}
}