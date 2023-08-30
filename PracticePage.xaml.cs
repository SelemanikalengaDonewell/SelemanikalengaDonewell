namespace EnvironmentApp3;

public partial class PracticePage : ContentPage
{
	public PracticePage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new SurveyPage());
    }
}