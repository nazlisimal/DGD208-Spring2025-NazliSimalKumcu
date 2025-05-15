public static class ItemDatabase
{
    public static List<Item> AllItems = new List<Item>
    {
        // Foods
        new Item { 
            Name = "Chew Stick", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Dog }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 15,
            Duration = 2.5f  // Takes 2.5 seconds to eat
        },
        new Item { 
            Name = "Wet Dog Food", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Dog }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 30,
            Duration = 3.0f  // Takes 3 seconds to eat
        },
        new Item { 
            Name = "Cat Food", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Cat }, 
            AffectedStat = PetStat.Hunger, 
            EffectAmount = 25,
            Duration = 2.5f
        },
        new Item { 
            Name = "Stick Treats", 
            Type = ItemType.Food, 
            CompatibleWith = new List<PetType> { PetType.Cat }, 
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
