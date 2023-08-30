namespace EnvironmentApp3;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
		read_In_List();
    }
	List<Data_Models> list = new List<Data_Models>();
	Sign_Up obj = new Sign_Up();

	public void read_In_List()
	{
		list = obj.Read().Result;
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (Sign_Up.name == list[i].Name)
				{
                    byte[] imageAsBytes = list[i].Images;
                    var stream = new MemoryStream(imageAsBytes);
                    Image_P_raed.Source = ImageSource.FromStream(() => stream);
					FullName.Text = list[i].Name;
					Gmail.Text = list[i].Email;
					Gender.Text = list[i].Gender;
					Country.Text = list[i].Country;
					UserName.Text =list[i].UserName;
					Id.Text = list[i].Id.ToString();
				}
				else
				{
					DisplayAlert("Wrong Search", "Please Enter A correct Name","Ok");
				}
			}
		}


	}

}