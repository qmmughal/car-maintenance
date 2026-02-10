using CarMaintenanceApp.ViewModels;

namespace CarMaintenanceApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new OilChangeViewModel();
    }
}
