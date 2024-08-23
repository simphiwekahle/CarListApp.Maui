using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui.Views;

public partial class CarDetailsPage : ContentPage
{
	public CarDetailsPage(CarDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}