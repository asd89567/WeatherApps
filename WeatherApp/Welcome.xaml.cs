namespace WeatherApp;

public partial class Welcome : ContentPage
{
	public Welcome()
	{
		InitializeComponent();
	}
	private void BtnGetStarted_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new WeatherPage());
	}
}