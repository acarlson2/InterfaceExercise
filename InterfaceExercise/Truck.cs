using System;

public class Truck: IVehicle, ICompany
{
    public Truck()
    {

    }

    public string Name {get; set;}
    public string Year {get; set;}
    public double Miles {get; set;}
    public bool IsElectric {get; set;}
    public string CompanyMotto {get; set;}
    public string CompanyName {get; set;}
    public bool IsWorkVehicle {get; set;}
    public bool BedIsCovered {get; set;}

    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Name} {CompanyName}:");
        Console.WriteLine($"Number of Miles: {Miles}");
        Console.WriteLine($"Work Vehicle: {IsWorkVehicle}");
        Console.WriteLine($"Bed Is Covered: {BedIsCovered}");
        Console.WriteLine($"Is Electric: {IsElectric}");
        Console.WriteLine("");
        Console.WriteLine(CompanyMotto);
        Console.WriteLine("---------------------------------------------");
    }
}