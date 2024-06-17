using System;

public class SUV: IVehicle, ICompany
{
    public SUV()
    {

    }

    public string Name {get; set;}
    public string Year {get; set;}
    public double Miles {get; set;}
    public bool IsElectric {get; set;}
    public string CompanyMotto {get; set;}
    public string CompanyName {get; set;}
    public int NumberOfSeats {get; set;}
    public bool HasRearCameras {get; set;}

    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Name} {CompanyName}:");
        Console.WriteLine($"Number of Miles: {Miles}");
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        Console.WriteLine($"Has Rear Cameras: {HasRearCameras}");
        Console.WriteLine($"Is Electric: {IsElectric}");
        Console.WriteLine("");
        Console.WriteLine(CompanyMotto);
        Console.WriteLine("---------------------------------------------");
    }
}