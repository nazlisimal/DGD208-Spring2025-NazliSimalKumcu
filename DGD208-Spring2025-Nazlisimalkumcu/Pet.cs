using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Pet
{
    public string Name { get; set; }
    public PetType Type { get; set; }
    
    // Pet stats
    private int _hunger = 50;
    private int _sleep = 50;
    private int _fun = 50;
    
    // Constants for stat limits
    private const int MIN_STAT = 0;
    private const int MAX_STAT = 100;

    public int Hunger 
    { 
        get => _hunger;
        private set => _hunger = Math.Clamp(value, MIN_STAT, MAX_STAT);
    }
    
    public int Sleep 
    { 
        get => _sleep;
        private set => _sleep = Math.Clamp(value, MIN_STAT, MAX_STAT);
    }
    
    public int Fun 
    { 
        get => _fun;
        private set => _fun = Math.Clamp(value, MIN_STAT, MAX_STAT);
    }

    public async Task<bool> UseItem(Item item)
    {
        if (!item.CompatibleWith.Contains(Type))
        {
            Console.WriteLine($"{Name} cannot use {item.Name}!");
            return false;
        }

        Console.WriteLine($"{Name} is using {item.Name}...");
        await Task.Delay(TimeSpan.FromSeconds(item.Duration));

        switch (item.AffectedStat)
        {
            case PetStat.Hunger:
                Hunger += item.EffectAmount;
                Console.WriteLine($"{Name}'s hunger is now {Hunger}%");
                break;
            case PetStat.Sleep:
                Sleep += item.EffectAmount;
                Console.WriteLine($"{Name}'s sleep is now {Sleep}%");
                break;
            case PetStat.Fun:
                Fun += item.EffectAmount;
                Console.WriteLine($"{Name}'s fun is now {Fun}%");
                break;
        }

        return true;
    }

    public override string ToString()
    {
        return $"{Name} the {Type} (Hunger: {Hunger}%, Sleep: {Sleep}%, Fun: {Fun}%)";
    }
} 
