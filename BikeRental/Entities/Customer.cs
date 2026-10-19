namespace BikeRental.Entities;

internal class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public bool IsMember { get; set; }

    public Customer(string name, int age, bool isMember)
    {
        Id = Guid.NewGuid();
        Name = name;
        Age = age;
        IsMember = isMember;
    }
}
