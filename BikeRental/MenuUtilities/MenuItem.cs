namespace BikeRental.MenuUtilities;

public class MenuItem
{
    public string Title { get; private set; } = string.Empty;
    public Action Action { get; private set; }

    public MenuItem(string title, Action action)
    {
        Title = title;
        Action = action;
    }
}
