namespace EnvironmentApp3;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
       // Navigation.PushAsync(new Login_page());
	}
    

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SocialPage());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new PhysicalPagexaml());
    }

    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ComunityPage());
    }

    private void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new HealthPages());
    }
}

