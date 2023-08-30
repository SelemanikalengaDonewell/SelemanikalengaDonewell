namespace EnvironmentApp3;

public partial class EmptyPage : ContentPage
{
	public EmptyPage()
	{
		InitializeComponent();
	}

    private void postB_Clicked(object sender, EventArgs e)
    {
		Sign_Up sign=new Sign_Up();
		ListV.ItemsSource = sign.Read().Result;
    }
}