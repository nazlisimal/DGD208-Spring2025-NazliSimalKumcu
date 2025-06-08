public static class ItemDatabase
{
    public static List<Item> AllItems = new List<Item>
    {
        // Foods
        new Item { 
            Name = "Chew Stick", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Puppy }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 15,
            Duration = 2.5f  // Takes 2.5 seconds to eat
        },
        new Item { 
            Name = "Wet Dog Food", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Puppy }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 30,
            Duration = 3.0f  // Takes 3 seconds to eat
        },
        new Item { 
            Name = "Cat Food", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Kitten }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 25,
            Duration = 2.5f
        },
        new Item { 
            Name = "Stick Treats", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Kitten }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 20,
            Duration = 1.5f  // Quick treat
        },
        new Item { 
            Name = "Bird Seed", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Bird }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 10,
            Duration = 1.0f
        },
        new Item { 
            Name = "Millets", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Bird }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 20,
            Duration = 2.0f
        },
        new Item { 
            Name = "Greens", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Turtle }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 20,
            Duration = 2.5f
        },
        new Item { 
            Name = "Apple", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Turtle }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 25,
            Duration = 3.0f
        },
        new Item { 
            Name = "Carrots", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Rabbit }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 15,
            Duration = 3.0f  // Takes time to chew
        },
        new Item { 
            Name = "Potatoes", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Rabbit }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 25,
            Duration = 4.0f  // Lots to munch through
        },
        // Universal Foods
        new Item {
            Name = "Vitamin Treat",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy, PetTypes.Kitten, PetTypes.Bird },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f  // Quick treat
        },
        new Item {
            Name = "Gourmet Dinner",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy, PetTypes.Kitten },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 40,
            Duration = 5.0f  // Fancy meal takes time
        },
        
        // Toys
        new Item {
            Name = "Bone Stick",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 4.0f  
        },
        new Item {
            Name = "Squeaky Toy",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 2.5f
        },
        new Item {
            Name = "Fishing Rod",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Kitten },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 3.0f 
        },
        new Item {
            Name = "Toy Mouse",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Kitten },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 2.0f
        },
        new Item {
            Name = "Water Fouintain",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Turtle },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 3.0f  
        },
        new Item {
            Name = "Bell",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Bird },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.5f
        },
        new Item {
            Name = "Play Table",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Rabbit },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 2.0f  
        },
        new Item {
            Name = "Vegetable Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Turtle },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 1.5f
        },
        new Item {
            Name = "Chew Toy",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Rabbit },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 3.5f  
        },
        new Item {
            Name = "Swing",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Bird },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 4.0f  
        },
        
        // Universal Toys
        new Item {
            Name = "Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy, PetTypes.Kitten, PetTypes.Bird, PetTypes.Rabbit, PetTypes.Turtle },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 2.0f
        },
        
        // Sleep Items
        new Item {
            Name = "Pet Bed",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy, PetTypes.Kitten },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 30,
            Duration = 6.0f 
        },
        new Item {
            Name = "Blanket",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Puppy, PetTypes.Kitten, PetTypes.Rabbit },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 20,
            Duration = 4.0f
        },
        new Item {
            Name = "Cage",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Bird },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 3.0f
        },
        new Item {
            Name = "Rock",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Turtle },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 2.0f
        },
        new Item {
            Name = "Hay bed",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Rabbit },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 5.0f  
        }
    };
    }
