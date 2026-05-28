namespace SafeNetVPN.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (UsernameEntry.Text == "johnny" && PasswordEntry.Text == "123456")
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
        else
        {
            await DisplayAlert("Fehler", "Benutzername oder Passwort ist falsch.", "OK");
        }
    }
}