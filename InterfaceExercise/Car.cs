using System;

public class Car: IVehicle, ICompany
{
    public Car()
    {

    }

    public string Name {get; set;}
    public string Year {get; set;}
    public double Miles {get; set;}
    public bool IsElectric {get; set;}
    public string CompanyMotto {get; set;}
    public string CompanyName {get; set;}
    public bool HasTrunk {get; set;}
    public bool IsAutomatic {get; set;}

    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Name} {CompanyName}:");
        Console.WriteLine($"Number of Miles: {Miles}");
        Console.WriteLine($"Has Trunk: {HasTrunk}");
        Console.WriteLine($"Is Automatic: {IsAutomatic}");
        Console.WriteLine($"Is Electric: {IsElectric}");
        Console.WriteLine("");
        Console.WriteLine(CompanyMotto);
        Console.WriteLine("---------------------------------------------");
    }
}