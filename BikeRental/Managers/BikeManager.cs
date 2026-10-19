using BikeRental.Entities.Bikes;

namespace BikeRental.Managers;

internal class BikeManager
{
    private List<BaseBike> bikes;
    public IReadOnlyList<BaseBike> Bikes => bikes;

    public BikeManager()
    {
        bikes = new List<BaseBike>();
    }

    public void ListBikes()
    {
        throw new NotImplementedException();
    }

    public void RentBike()
    {
        throw new NotImplementedException();
    }

    public void ReturnBike()
    {
        throw new NotImplementedException();
    }

    public void ChargeBike()
    {
        throw new NotImplementedException();
    }
}
