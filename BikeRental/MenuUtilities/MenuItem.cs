namespace BikeRental.MenuUtilities;

public class MenuItem
{
    public string Title { get; private set; } = string.Empty;

    public MenuItem(string title)
    {
        Title = title;
    }
}
