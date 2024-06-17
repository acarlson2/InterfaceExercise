using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            Car civic = new Car();
            civic.Name = "Civic";
            civic.Year = "2018";
            civic.Miles = 2000;
            civic.IsElectric = false;
            civic.CompanyName = "Honda";
            civic.CompanyMotto = "Power of Dreams";
            civic.HasTrunk = true;
            civic.IsAutomatic = true;

            Truck f150 = new Truck();
            f150.Name = "F-150";
            f150.Year = "2024";
            f150.Miles = 500;
            f150.IsElectric = true;
            f150.CompanyName = "Ford";
            f150.CompanyMotto = "Built Ford Tough";
            f150.IsWorkVehicle = false;
            f150.BedIsCovered = false;

            SUV forester = new SUV();
            forester.Name = "Forester";
            forester.Year = "2019";
            forester.Miles = 4000;
            forester.IsElectric = false;
            forester.CompanyName = "Subaru";
            forester.CompanyMotto = "Love. It's What Makes a Subaru, a Subaru";
            forester.NumberOfSeats = 4;
            forester.HasRearCameras = true;

            civic.DisplayDetails();
            f150.DisplayDetails();
            forester.DisplayDetails();
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
