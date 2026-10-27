namespace MenuBuilder;

internal class MenuItem
{
    public string Name { get; private set; }
    public int Index { get; private set; }
    public Action Action { get; private set; }

    public MenuItem(string name, Action action, int index)
    {
        Name = name;
        Action = action;
        Index = index;
    }
}
