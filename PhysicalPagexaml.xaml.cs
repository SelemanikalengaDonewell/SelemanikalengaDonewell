using EnvironmentApp3.Pages2;

namespace EnvironmentApp3;

public partial class PhysicalPagexaml : ContentPage
{
	public PhysicalPagexaml()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new Phiscal2());
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new TakeCare());
    }

    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Ages());
    }
}