using Microsoft.Maui.Storage;

namespace SafeNetVPN.Pages;

    public partial class MainPage : ContentPage
    {
    private bool isConnected = false;
    private int lastServerIndex = 0;
    private bool isChangingServerBack = false;

    public MainPage()
        {
            InitializeComponent();
            ServerPicker.SelectedIndex = 0;
            lastServerIndex = ServerPicker.SelectedIndex;
        }

        private async void ConnectButton_Clicked(object sender, EventArgs e)
    {
        if (isConnected == false)
        {
            ConnectButton.IsEnabled = false;
            ConnectButton.Text = "Bitte warten...";

            StatusLabel.Text = "Status: Verbindung wird hergestellt...";
            StatusCircle.Fill = Color.FromArgb("#FFA500");
            StatusCircle.Stroke = Color.FromArgb("#FFA500");

            IpEntry.Text = "IP-Adresse wird geladen...";
            ConnectionEntry.Text = "Verbindung wird vorbereitet...";

            await Task.Delay(2000);

            isConnected = true;

            StatusLabel.Text = "Status: Verbunden";
            StatusCircle.Fill = Color.FromArgb("#008000");
            StatusCircle.Stroke = Color.FromArgb("#008000");

            ConnectButton.Text = "Trennen";

            IpEntry.Text = GetIpForSelectedServer();
            ConnectionEntry.Text = "Verschlüsselt";

            ConnectButton.IsEnabled = true;
        }
        else
        {
            isConnected = false;

            StatusLabel.Text = "Status: Nicht verbunden";

            ConnectButton.Text = "Verbinden";

            IpEntry.Text = "";
            ConnectionEntry.Text = "";
        }
    }

    private async void ServerPicker_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (isChangingServerBack)
            return;

        if (isConnected)
        {
            await DisplayAlert("Hinweis", "Trenne zuerst alte Verbindung", "OK");

            isChangingServerBack = true;
            ServerPicker.SelectedIndex = lastServerIndex;
            isChangingServerBack = false;

            ServerPicker.Title = "Trenne zuerst alte Verbindung";
        }
        else
        {
            lastServerIndex = ServerPicker.SelectedIndex;
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