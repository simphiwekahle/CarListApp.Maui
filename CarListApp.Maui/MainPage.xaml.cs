using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui;

public partial class MainPage : ContentPage
{
    public MainPage(CarListViewModel vm)
    {
        InitializeComponent();
       BindingContext = vm;
    }

    
}
