public class Game
{
    private bool _isRunning;
    private PetManager _manager = new PetManager();
    private string _studentName = "Nazlı Şimal Kumcu";
    private string _studentNumber = "2305041049";

    public async Task GameLoop()
    {
        try
        {
            // Initialize the game
            Initialize();

            // Main game loop
            _isRunning = true;
            while (_isRunning)
            {
                // Display menu and get player input
                string userChoice = GetUserInput();

                // Process the player's choice
                await ProcessUserChoice(userChoice);
            }

            Console.WriteLine("Thanks for playing!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    private void Initialize()
    {
        Console.Title = "Pet Simulator";
        Console.WriteLine("Welcome to Pet Simulator!");
        Console.WriteLine("========================\n");
    }

    private string GetUserInput()
    {
        var menu = new Menu<string>("Pet Simulator", new List<string>
        {
            "Adopt a Pet",
            "View Pets",
            "Use Item",
            "Show Creator Info",
            "Exit"
        }, s => s);
        return menu.ShowAndGetSelection();
    }

    private async Task ProcessUserChoice(string choice)
    {
        try
        {
            switch (choice)
            {
                case "Adopt a Pet":
                    AdoptPet();
                    break;

                case "View Pets":
                    _manager.ShowAllPets();
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "Use Item":
                    await UseItemOnPet();
                    break;

                case "Show Creator Info":
                    Console.WriteLine($"Created by {_studentName}, {_studentNumber}");
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    break;

                case "Exit":
                    _isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private void AdoptPet()
    {
        // Step 1: Choose pet type
        var petTypeMenu = new Menu<PetType>(
            "Choose a Pet Type",
            Enum.GetValues(typeof(PetType)).Cast<PetType>().ToList(),
            type => ((int)type + 1) + ". " + type.ToString()
        );
        PetType selectedType = petTypeMenu.ShowAndGetSelection();
        if (!Enum.IsDefined(typeof(PetType), selectedType)) return;

        // Step 2: Enter custom name
        Console.Write("Enter a name for your new " + selectedType + ": ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name)) return;

        Pet pet = new Pet
        {
            Name = name.Trim(),
            Type = selectedType
        };

        _manager.AddPet(pet);
        Console.WriteLine($"{pet.Name} the {pet.Type} has been adopted!");
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    private async Task UseItemOnPet()
    {
        List<Pet> pets = _manager.GetAllPets();
        if (pets.Count == 0)
        {
            Console.WriteLine("You don't have any pets to use items on!");
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
            return;
        }

        var petMenu = new Menu<Pet>("Select Pet", pets, p => p.ToString());
        Pet selectedPet = petMenu.ShowAndGetSelection();
        if (selectedPet == null) return;

        // Filter items for the selected pet
        var compatibleItems = ItemDatabase.Items
            .Where(i => i.CompatibleWith.Contains(selectedPet.Type))
            .ToList();

        if (compatibleItems.Count == 0)
        {
            Console.WriteLine($"No items available for {selectedPet.Name}!");
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
            return;
        }

        // Group items by type
        var foodItems = compatibleItems.Where(i => i.Type == ItemType.Food).ToList();
        var toyItems = compatibleItems.Where(i => i.Type == ItemType.Toy).ToList();
        var sleepItems = compatibleItems.Where(i => i.Type == ItemType.Sleep).ToList();

        Console.WriteLine("\n=== Available Items for " + selectedPet.Name + " ===\n");

        if (foodItems.Count > 0)
        {
            Console.WriteLine("Food Items:");
            Console.WriteLine("-----------");
            for (int i = 0; i < foodItems.Count; i++)
            {
                var item = foodItems[i];
                Console.WriteLine($"{i + 1}. {item.Name} (Affects {item.AffectedStat} by {item.EffectAmount})");
            }
        }

        if (toyItems.Count > 0)
        {
            Console.WriteLine("\nToy Items:");
            Console.WriteLine("-----------");
            for (int i = 0; i < toyItems.Count; i++)
            {
                var item = toyItems[i];
                Console.WriteLine($"{foodItems.Count + i + 1}. {item.Name} (Affects {item.AffectedStat} by {item.EffectAmount})");
            }
        }

        if (sleepItems.Count > 0)
        {
            Console.WriteLine("\nSleep Items:");
            Console.WriteLine("------------");
            for (int i = 0; i < sleepItems.Count; i++)
            {
                var item = sleepItems[i];
                Console.WriteLine($"{foodItems.Count + toyItems.Count + i + 1}. {item.Name} (Affects {item.AffectedStat} by {item.EffectAmount})");
            }
        }

        Console.WriteLine("\n0. Go Back\n");
        Console.Write($"Enter selection (0-{compatibleItems.Count}): ");
        
        if (int.TryParse(Console.ReadLine(), out int selection))
        {
            if (selection == 0) return;
            if (selection > 0 && selection <= compatibleItems.Count)
            {
                Item selectedItem = compatibleItems[selection - 1];
                await selectedPet.UseItem(selectedItem);
            }
            else
            {
                Console.WriteLine("Invalid selection!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
