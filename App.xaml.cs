namespace EnvironmentApp3;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
		MainPage = new SignUp();	
		//MainPage = new Blogs();
       //MainPage.Navigation.PushAsync(new EmptyPage());
	}
}
