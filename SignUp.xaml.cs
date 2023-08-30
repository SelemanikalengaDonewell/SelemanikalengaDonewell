using SQLite;

namespace EnvironmentApp3;

public partial class SignUp : ContentPage
{
    static string link = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Datesdb");
    SQLiteAsyncConnection cone = new SQLiteAsyncConnection(link);
    public SignUp()
	{
		InitializeComponent();
	}
    public static string name;
    byte[] data = { 000, 000, 0000, 002 };

    public string saving()
    {
        try
        {
            cone.CreateTableAsync<Data_Models>();
            var table_Data = new Data_Models
            {
                Images = ImageToBinary(Image_Path),
                Name = Full_Name.Text,
                Email = Gmail.Text,
                Gender = Gender.Text,
                Country = Country.Text,
                UserName = UserName.Text,
                Password = Confirm_Password.Text
            };
            cone.InsertAsync(table_Data);
            return "saved";
        }
        catch (Exception ex) { DisplayAlert("Check Con", "Please Verify At:" + ex.Message, "Cancel"); }
        return "try later";
    }

    string Image_Path;

    static PickOptions options;
    public async void openfiles()
    {

        var result = await FilePicker.Default.PickAsync(options);
        if (result != null)
        {
            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
            {
                using var stream = await result.OpenReadAsync();
                var image = ImageSource.FromStream(() => stream);
                Image_Path = result.FullPath;

            }
        }
        // return imagepath;
    }


    public Task<List<Data_Models>> Read()
    {
        return cone.Table<Data_Models>().ToListAsync();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        name = Full_Name.Text;
       

       // DisplayAlert("SAVING PROCESS", "PROCESS :" + saving(), "OK");
        Navigation.PushAsync(new EmptyPage());

    }

    public static byte[] ImageToBinary(string imagePath)
    {
        FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[fileStream.Length];
        fileStream.Read(buffer, 0, (int)fileStream.Length);
        fileStream.Close();
        return buffer;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        openfiles();
        Image_Profile.Source = Image_Path;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
       
    }

    private void SignUp_Clicked(object sender, EventArgs e)
    {
        
    }

    private void SignUpS_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EmptyPage());
    }
}