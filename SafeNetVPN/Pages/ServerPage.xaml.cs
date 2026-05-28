namespace SafeNetVPN.Pages;

public partial class ServerPage : ContentPage
{
    public ServerPage()
    {
        InitializeComponent();

        ServerPagePicker.SelectedIndex = 0;
        ServerPageIpEntry.Text = "192.168.1.10";
        ServerPageConnectionEntry.Text = "Verschlüsselt";
    }

    private void ServerPagePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedServer = ServerPagePicker.SelectedItem?.ToString() ?? "";

        if (selectedServer == "Deutschland - Frankfurt")
        {
            ServerPageIpEntry.Text = "192.168.1.10";
        }
        else if (selectedServer == "USA - New York")
        {
            ServerPageIpEntry.Text = "172.16.0.25";
        }
        else if (selectedServer == "Polen - Warschau")
        {
            ServerPageIpEntry.Text = "10.0.0.45";
        }
        else if (selectedServer == "Ukraine - Kyiv")
        {
            ServerPageIpEntry.Text = "192.168.50.20";
        }

        ServerPageConnectionEntry.Text = "Verschlüsselt";
    }

    private async void DisconnectButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void GoToMainPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void GoToServerPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ServerPage");
    }

    private async void GoToSettingsPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SettingsPage");
    }
}