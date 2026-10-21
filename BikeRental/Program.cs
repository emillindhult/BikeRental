using BikeRental.Entities.Bikes;
using BikeRental.Managers;

namespace BikeRental;

internal class Program
{
    static void Main(string[] args)
    {
        var app = new App();
        app.Run();
    }
}
