public interface IVehicle
{
    public string Name {get; set;}
    public string Year {get; set;}
    public double Miles {get; set;}
    public bool IsElectric {get; set;}

    public void DisplayDetails();
}