using System;
using System.Collections.Generic;

public class PetManager
{
    private readonly List<Pet> _pets = new List<Pet>();

    public void AddPet(Pet pet)
    {
        if (pet == null)
            throw new ArgumentNullException(nameof(pet));
            
        _pets.Add(pet);
    }

    public List<Pet> GetAllPets()
    {
        return new List<Pet>(_pets);
    }

    public void ShowAllPets()
    {
        if (_pets.Count == 0)
        {
            Console.WriteLine("You don't have any pets yet!");
            return;
        }

        Console.WriteLine("\nYour Pets:");
        Console.WriteLine("==========");
        foreach (var pet in _pets)
        {
            Console.WriteLine(pet);
        }
    }
} 
