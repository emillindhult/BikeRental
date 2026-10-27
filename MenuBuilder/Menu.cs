namespace MenuBuilder;

public class Menu
{
    private List<MenuItem> menuItems = [];
    private int selectedItemIndex;
    private readonly string title;

    public Menu(string title)
    {
        this.title = title;
    }

    public Menu Add(string name, Action action)
    {
        this.menuItems.Add(new MenuItem(name, action, this.menuItems.Count));
        return this;
    }

    public void Display()
    {
        var menuDisplay = new MenuDisplay(this.menuItems);
        menuDisplay.Display(selectedItemIndex);
    }
}
