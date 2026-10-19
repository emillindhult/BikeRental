using BikeRental.Entities;

namespace BikeRental.Managers;

internal class CustomerManager
{
    private List<Customer> customers;
    public IReadOnlyList<Customer> Customers => customers;

    public CustomerManager()
    {
        customers = new List<Customer>();
    }

    public void RegisterCustomer(string name, int age, bool isMember)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (age < 15)
        {
            throw new ArgumentException("Age cannot be less than 15, {0}",nameof(age));
        }

        customers.Add(new Customer(name, age, isMember));
    }
}
