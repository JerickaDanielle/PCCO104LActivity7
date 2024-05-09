using System;

public class LuxuryBag
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }

    private string Material { get; set; }
    private bool IsLimitedEdition { get; set; }
    private string Color { get; set; }


    public LuxuryBag()
    {
        Brand = "Unknown";
        Model = "Unknown";
        Price = 0;
        Material = "Unknown";
        IsLimitedEdition = false;
        Color = "Unknown";
    }

    public LuxuryBag(string brand, string model, decimal price)
    {
        Brand = brand;
        Model = model;
        Price = price;
        Material = "Leather"; 
        IsLimitedEdition = false;
        Color = "Pink"; 
    }


    public LuxuryBag(string brand, string model, decimal price, string material, bool isLimitedEdition, string color)
    {
        Brand = brand;
        Model = model;
        Price = price;
        Material = material;
        IsLimitedEdition = isLimitedEdition;
        Color = color;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine($"Limited Edition: {(IsLimitedEdition ? "Yes" : "No")}");
        Console.WriteLine($"Color: {Color}");
    }
    
    public bool IsWithinBudget(decimal budget)
    {
        return Price <= budget;
    }


    private bool Authenticate()
    {
        return true;
    }
    public void Purchase(decimal budget)
    {
        if (IsWithinBudget(budget))
        {
            if (Authenticate())
            {
                Console.WriteLine($"Congratulations! You have purchased the {Brand} {Model}.");
            }
            else
            {
                Console.WriteLine("Authentication failed. Purchase unsuccessful.");
            }
        }
        else
        {
            Console.WriteLine($"The price of {Brand} {Model} is beyond your budget. Purchase unsuccessful.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LuxuryBag bag1 = new LuxuryBag("Marc Jacobs", "Snapshot", 13000);
        LuxuryBag bag2 = new LuxuryBag("Louis Vuitton", "Neverfull", 384000, "Leather", false, "Brown");
        LuxuryBag bag3 = new LuxuryBag("Channel", "Classic Flap", 510000, "Velvet", true, "Red");


        bag1.DisplayDetails();
        bag2.DisplayDetails();
        bag3.DisplayDetails();


        decimal budget = 500000;
        Console.WriteLine($"Is bag 1 within budget? {bag1.IsWithinBudget(budget)}");
        Console.WriteLine($"Is bag 2 within budget? {bag2.IsWithinBudget(budget)}");
        Console.WriteLine($"Is bag 3 within budget? {bag3.IsWithinBudget(budget)}");


        bag1.Purchase(budget);
        bag2.Purchase(budget);
        bag3.Purchase(budget);
    }
}

