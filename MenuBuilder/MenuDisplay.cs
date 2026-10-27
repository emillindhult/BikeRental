namespace MenuBuilder;

internal class MenuDisplay
{
    private readonly List<MenuItem> _items;

    public MenuDisplay(List<MenuItem> items)
    {
        _items = items;
    }

    public void Display(int selectedItemIndex)
    {
        ConsoleKeyInfo key;

        while (true)
        {
            Console.Clear();
            for (int i = 0; i < _items.Count; i++)
            {
                if (i == selectedItemIndex)
                {
                    WriteSelectedMenuItem(i);
                }
                else
                {
                    WriteMenuItem(i);
                }
            }

            key = Console.ReadKey(true);

            do
            {
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (--selectedItemIndex < 0)
                        {
                            selectedItemIndex = _items.Count - 1;
                            break;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (++selectedItemIndex >= _items.Count)
                        {
                            selectedItemIndex = 0;
                            break;
                        }
                        break;
                }
            } while (key.Key != ConsoleKey.Enter);
        }
    }

    private void WriteSelectedMenuItem(int index)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(_items[index].Name);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    private void WriteMenuItem(int index)
    {
        Console.WriteLine(_items[index].Name);
    }
}
