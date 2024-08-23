using CarListApp.Maui.Views;

namespace CarListApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));

            InitializeComponent();
        }
    }
}
