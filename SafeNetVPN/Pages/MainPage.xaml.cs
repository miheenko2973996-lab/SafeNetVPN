using SafeNetVPN.Models;
using SafeNetVPN.PageModels;

namespace SafeNetVPN.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}