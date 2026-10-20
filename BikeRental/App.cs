using BikeRental.Managers;

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
}
