public class Game
{
    private bool _isRunning;
    private PetManager _manager = new PetManager();
    private string _studentName = "Nazlı Şimal Kumcu";
    private string _studentNumber = "2305041049";

    public async Task GameLoop()
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

    private void Initialize()
    {
        // Game initialization logic here if needed
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
                UseItemOnPet();
                break;

            case "Show Creator Info":
                Console.WriteLine($"Created by {_studentName}, {_studentNumber}");
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                break;

            case "Exit":
                _isRunning = false;
                break;
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

    private void UseItemOnPet()
    {
        List<Pet> pets = _manager.GetAllPets();
        var petMenu = new Menu<Pet>("Select Pet", pets, p => p.Name);
        Pet selectedPet = petMenu.ShowAndGetSelection();
        if (selectedPet == null) return;

        var itemMenu = new Menu<Item>("Select Item", ItemDatabase.Items, i => i.Name);
        Item item = itemMenu.ShowAndGetSelection();
        if (item == null) return;

        _ = selectedPet.UseItem(item);
    }
}
