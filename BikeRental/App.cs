using BikeRental.Managers;
using MenuBuilder;

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
        var menu = new Menu("Bike Rental")
            .Add("This is an option", () => Console.WriteLine())
            .Add("Option 2", () => Console.WriteLine());

        menu.Display();
    }
}
