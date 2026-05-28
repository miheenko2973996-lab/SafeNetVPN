using Microsoft.Maui.Storage;

namespace SafeNetVPN.Pages;

public partial class MainPage : ContentPage
{
    private bool isConnected = false;

    public MainPage()
    {
        InitializeComponent();
        ServerPicker.SelectedIndex = 0;
    }

    private void ConnectButton_Clicked(object sender, EventArgs e)
    {
        if (isConnected == false)
        {
            isConnected = true;

            StatusLabel.Text = "Status: Verbunden";
            StatusCircle.Fill = Color.FromArgb("#008000");
            StatusCircle.Stroke = Color.FromArgb("#008000");
            ConnectButton.Text = "Trennen";

            IpEntry.Text = GetIpForSelectedServer();
            ConnectionEntry.Text = "Verschlüsselt";
        }
        else
        {
            isConnected = false;

            StatusLabel.Text = "Status: Nicht verbunden";
            StatusCircle.Fill = Color.FromArgb("#B00020");
            StatusCircle.Stroke = Color.FromArgb("#B00020");
            ConnectButton.Text = "Verbinden";

            IpEntry.Text = "";
            ConnectionEntry.Text = "";
        }
    }

    private string GetIpForSelectedServer()
    {
        string selectedServer = ServerPicker.SelectedItem?.ToString() ?? "";

        if (selectedServer == "Deutschland - Frankfurt")
            return "192.168.1.10";

        if (selectedServer == "USA - New York")
            return "172.16.0.25";

        if (selectedServer == "Polen - Warschau")
            return "10.0.0.45";

        if (selectedServer == "Ukraine - Kyiv")
            return "192.168.50.20";

        return "192.168.1.10";
    }

    private async void GoToMainPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void GoToServerPage_Clicked(object sender, EventArgs e)
    {
        LoadDefaultServer();

        string defaultServer = Preferences.Get("DefaultServer", "Deutschland - Frankfurt");

        await DisplayAlert("Server",
            $"Standardserver wurde geladen: {defaultServer}",
            "OK");
    }

    private async void GoToSettingsPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SettingsPage");
    }
    private void LoadDefaultServer()
    {
        string defaultServer = Preferences.Get("DefaultServer", "Deutschland - Frankfurt");

        if (defaultServer == "Deutschland - Frankfurt")
            ServerPicker.SelectedIndex = 0;
        else if (defaultServer == "USA - New York")
            ServerPicker.SelectedIndex = 1;
        else if (defaultServer == "Polen - Warschau")
            ServerPicker.SelectedIndex = 2;
        else if (defaultServer == "Ukraine - Kyiv")
            ServerPicker.SelectedIndex = 3;

        IpEntry.Text = GetIpForSelectedServer();

        if (isConnected)
        {
            ConnectionEntry.Text = "Verschlüsselt";
        }
    }
}