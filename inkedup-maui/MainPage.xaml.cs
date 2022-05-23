namespace inkedup_maui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void BtnMoveToPens_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PensPage());
	}
}

