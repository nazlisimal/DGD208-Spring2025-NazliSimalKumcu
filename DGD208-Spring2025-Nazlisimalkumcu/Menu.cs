/// <summary>Add commentMore actions
/// A generic menu system that can display a list of items and get user selection.
/// </summary>
/// <typeparam name="T">The type of items in the menu</typeparam>
public class Menu<T>
{
    private readonly List<T> _items;
    private readonly string _title;
    private readonly Func<T, string> _displaySelector;

    public Menu(string title, List<T> items, Func<T, string> displaySelector)
    {
        _title = title;
        _items = items ?? new List<T>();
        _displaySelector = displaySelector ?? (item => item?.ToString() ?? "");
    }

    public T ShowAndGetSelection()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine($"No items available in {_title}. Press any key to continue...");
            Console.ReadKey();
            return default;
        }

        while (true)
        {
            Console.WriteLine($"\n=== {_title} ===\n");

            // Display all menu items with numbers
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_displaySelector(_items[i])}");
            }

            Console.WriteLine("\n0. Go Back\n");
            Console.Write("Enter selection (0-{0}): ", _items.Count);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int selection))
            {
                if (selection == 0)
                    return default;
                if (selection > 0 && selection <= _items.Count)
                    return _items[selection - 1];
            }

            Console.WriteLine($"Invalid selection. Please enter a number between 0 and {_items.Count}.");
            Console.WriteLine("Press any key to try again...");
            Console.ReadKey();
        }
    }
}
