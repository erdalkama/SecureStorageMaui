namespace SecureStorageMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Save(object sender, EventArgs e)
    {
        string savedToken = SaveToken.Text;
        if (!string.IsNullOrEmpty(savedToken))
        {
            await SecureStorage.Default.SetAsync("oauth_token", savedToken);
            SaveToken.Text = string.Empty;
            await DisplayAlert("SAVED", "Token saved", "Ok");
        }
        else
        {
            await DisplayAlert("ERROR", "Please enter the token", "Ok");
        }
    }

    private async void Show(System.Object sender, System.EventArgs e)
    {
        string oauthToken = await SecureStorage.Default.GetAsync("oauth_token");

        if (oauthToken == null)
        {
            ShowToken.Text = string.Empty;
            await DisplayAlert("ERROR", "Please enter the token and save.", "Ok");

        }
        else
        {
            ShowToken.Text = oauthToken;
        }
    }

    async void Delete(System.Object sender, System.EventArgs e)
    {
        if (!string.IsNullOrEmpty("oauth_token"))
        {
            _ = SecureStorage.Default.Remove("oauth_token");
            await DisplayAlert("DELETED", "Token deleted", "Ok");
        }
        else
        {
            await DisplayAlert("ERROR", "There is no token", "Ok");
        }
    }
}


