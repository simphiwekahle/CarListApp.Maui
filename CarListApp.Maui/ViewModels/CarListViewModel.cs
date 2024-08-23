using CarListApp.Maui.Models;
using CarListApp.Maui.Services;
using CarListApp.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CarListApp.Maui.ViewModels;

public partial class CarListViewModel : BaseViewModel
{
    private readonly CarService service;
    public ObservableCollection<Car> Cars { get; private set; } = new ();
    public CarListViewModel(CarService service)
    {
        Title = "Car List";
        this.service = service;
    }

    [ObservableProperty]
    bool isRefreshing;

    [RelayCommand]
    async Task GetCarList()
    {
        if (IsLoading) return;

        try
        {
            IsLoading = true;
            if (Cars.Any())
                Cars.Clear();

            var cars = service.GetCars();
            foreach (var car in cars)
            {
                Cars.Add(car);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get cars: {ex.Message}");
            await Shell.Current.DisplayAlert("Error", "Failed to get car list.", "Ok");
        }
        finally
        {
            IsLoading = false;
            IsRefreshing = false;
        }
    }

    [RelayCommand]
    async Task GetCarDetails(Car car)
    {
        if (car == null) return;

        await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
        {
            {nameof(Car), car}
        });
    }
}
