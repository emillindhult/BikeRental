namespace BikeRental.Entities.Bikes;

internal class ElectricBike : BaseBike
{
    public int Battery { get; private set; }

    public ElectricBike(decimal pricePerHour, bool isFree, int battery)
        : base(pricePerHour, isFree)
    {
        Battery = battery;
    }
}
