namespace BikeRental.MenuUtilities;

public class Menu
{
    private ItemCollection menuItems;
    private Menu? parent;
    private string title;

    public Menu(string title)
    {
        menuItems = new ItemCollection();
        this.title = title;
    }

    public Menu Add(string title, Action action)
    {
        menuItems.AddItem(title, action);
        return this;
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine(title);

        foreach (var item in menuItems.Items)
        {
            if (item == menuItems.SelectedItem)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(item.Title);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                continue;
            }
            Console.WriteLine(item.Title);
        }
    }

    public void ProcessInput()
    {
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.DownArrow)
            {
                menuItems.SelectNextItem();
                return;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                menuItems.SelectPreviousItem();
                return;
            }
        } while (key.Key != ConsoleKey.Enter);
    }

    public void Show()
    {
        while (true)
        {
            DisplayMenu();
            ProcessInput();
        }
    }
}
