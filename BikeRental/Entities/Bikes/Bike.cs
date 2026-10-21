namespace BikeRental.Entities.Bikes;

internal class Bike : BaseBike
{
    public Bike(decimal pricePerHour, bool isFree)
        : base(pricePerHour, isFree)
    {
    }
}
