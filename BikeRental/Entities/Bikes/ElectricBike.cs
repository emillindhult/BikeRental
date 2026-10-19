namespace BikeRental.Entities.Bikes;

internal class ElectricBike : BaseBike
{
    public int Battery { get; private set; }

    public ElectricBike(int id, decimal pricePerHour, bool isFree, int battery)
        : base(id, pricePerHour, isFree)
    {
        Battery = battery;
    }
}
