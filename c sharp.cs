using System;
using System.Collections.Generic;

class Tire
{
    public int TireId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Size { get; set; }
    // Add more properties as needed

    public override string ToString()
    {
        return $"{TireId} - {Brand} {Model} ({Size})";
    }
}

class TireManagementSystem
{
    private List<Tire> tires;

    public TireManagementSystem()
    {
        tires = new List<Tire>();
    }

    public void AddTire(Tire tire)
    {
        tire.TireId = tires.Count + 1;
        tires.Add(tire);
    }

    public void UpdateTire(int tireId, Tire updatedTire)
    {
        Tire existingTire = tires.Find(t => t.TireId == tireId);
        if (existingTire != null)
        {
            existingTire.Brand = updatedTire.Brand;
            existingTire.Model = updatedTire.Model;
            existingTire.Size = updatedTire.Size;
            // Update other properties as needed
        }
    }

    public Tire GetTireById(int tireId)
    {
        return tires.Find(t => t.TireId == tireId);
    }

    public List<Tire> GetAllTires()
    {
        return tires;
    }

    // Additional methods for deleting tires, searching, etc.
}

class Program
{
    static void Main()
    {
        TireManagementSystem tireSystem = new TireManagementSystem();

        // Example usage:
        tireSystem.AddTire(new Tire { Brand = "Michelin", Model = "Pilot Sport", Size = 18 });
        tireSystem.AddTire(new Tire { Brand = "Bridgestone", Model = "Potenza", Size = 19 });

        List<Tire> allTires = tireSystem.GetAllTires();
        foreach (Tire tire in allTires)
        {
            Console.WriteLine(tire);
        }

        // Add more interactions as needed
    }
}
