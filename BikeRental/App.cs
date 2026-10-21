using BikeRental.Managers;
using BikeRental.MenuUtilities;

namespace BikeRental;

public class App
{
    private readonly BikeManager _bikeManager;
    private readonly CustomerManager _customerManager;

    public App()
    {
        _bikeManager = new BikeManager();
        _customerManager = new CustomerManager();
    }

    public void Run()
    {
        var menu = new Menu("Bike Rental");
        menu.Show();
    }
}
