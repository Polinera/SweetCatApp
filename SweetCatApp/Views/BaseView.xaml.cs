namespace SweetCatApp.Views;

public partial class BaseView : ContentPage
{
	public BaseView()
	{
		InitializeComponent();
	}
	protected void OnMainPageClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}

	protected void OnProfilePageClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PetsProfilView());
	}

	protected void OnSettingsPageClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}
}