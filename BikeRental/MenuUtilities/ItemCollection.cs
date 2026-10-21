namespace BikeRental.MenuUtilities;

public class ItemCollection
{
    private readonly List<MenuItem> _items;
    private int selectedIndex = 0;
    public MenuItem SelectedItem { get; private set; }

    public IReadOnlyList<MenuItem> Items => _items;

    public ItemCollection()
    {
        _items = [];

        if (_items.Count <= 0)
            _items.Add(new MenuItem("Option 1"));

        _items.Add(new MenuItem("Option 1"));
        _items.Add(new MenuItem("Option 1"));
        _items.Add(new MenuItem("Option 1"));

        SelectedItem = _items[selectedIndex];
    }

    public void SelectNextItem()
    {
        if (++selectedIndex >= _items.Count)
        {
            selectedIndex = 0;
        }

        SelectedItem = _items[selectedIndex];
    }

    public void SelectPreviousItem()
    {
        if (--selectedIndex < 0)
        {
            selectedIndex = _items.Count - 1;
        }

        SelectedItem = _items[selectedIndex];
    }
}
