namespace BikeRental.Entities.Bikes;

internal abstract class BaseBike
{
    public Guid Id { get; private set; }
    public decimal PricePerHour { get; private set; }
    public bool IsFree { get; private set; }

    public BaseBike(decimal pricePerHour, bool isFree)
    {
        Id = Guid.NewGuid();
        PricePerHour = pricePerHour;
        IsFree = isFree;
    }

    public decimal CalculatePrice(int hours)
    {
        return PricePerHour * hours;
    }

    public void ChangeStatus()
    {
        IsFree = !IsFree;
    }
}
