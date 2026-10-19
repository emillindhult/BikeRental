namespace BikeRental.Entities.Bikes;

internal class Bike : BaseBike
{
    public Bike(int id, decimal pricePerHour, bool isFree)
        : base(id, pricePerHour, isFree)
    {
    }
}
