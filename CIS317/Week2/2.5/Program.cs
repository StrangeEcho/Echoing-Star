public class MainProgram {
    static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 2 Interface Performance Assessment\n\n");

        Car car1 = new Car("Toyota", "Rav4", false, "Virginia");
        Car car2 = new Car("Honda", "Civic", false, "New York");

        CargoTruck truck1 = new CargoTruck("Toyota", "Tundra", false, "North Carolina", "2000 pounds");
        CargoTruck truck2 = new CargoTruck("Dodge", "Ram", false, "Ohio", "1000 pounds");

        car1.Start();
        car2.Start();
        truck1.Start();
        truck2.Start();

        car2.Stop();

        car1.Drive("Chesapeake");
        car2.Drive("Richmond");
        truck1.Drive("Williamsburg");
        truck2.Drive("Newport News");

        List<IVehicle> vehicles = new List<IVehicle>();

        vehicles.Add(car1);
        vehicles.Add(car2);
        vehicles.Add(truck1);
        vehicles.Add(truck2);

        Console.WriteLine("\tList of vehicles:");
        foreach (IVehicle vehicle in vehicles) {
            PrintVehicleInfo(vehicle);
        }
        
        Console.WriteLine("\tWithout list:");
        
        Console.WriteLine(car1.ToString());
        Console.WriteLine(car2.ToString());
        Console.WriteLine(truck1.ToString());
        Console.WriteLine(truck2.ToString());

    }

    static private void PrintVehicleInfo(IVehicle vehicle) {
        Console.WriteLine(vehicle.ToString());
    }
}