using Microsoft.Maui.Storage;

namespace SafeNetVPN.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private async void SaveSettingsButton_Clicked(object sender, EventArgs e)
    {
        string selectedServer = DefaultServerPicker.SelectedItem?.ToString()
                                ?? DefaultServerPicker.Title
                                ?? "Deutschland - Frankfurt";

        Preferences.Set("DefaultServer", selectedServer);

        await DisplayAlert("Gespeichert",
            $"Standardserver wurde gespeichert: {selectedServer}",
            "OK");
    }

    private async void GoToMainPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void GoToServerPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void GoToSettingsPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SettingsPage");
    }
}