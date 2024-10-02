using System.Collections.Concurrent;

public class MainProgram {
    static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 1 Performance Assessment: Inheritance\n\n");

        Vehicle veh = new Vehicle(4, "blue", false, 2);
        Console.WriteLine(veh.ToString() + "\n");

        Bicycle bike = new Bicycle(2, "red", false, 1, 6, 2.5, 5.5);
        Console.WriteLine(bike.ToString() + "\n");

        Motorized moto = new Motorized(4, "purple", true, 3, "V4", true);
        Console.WriteLine(moto.ToString() + "\n");

        Car car = new Car(4, "grey", true, 4, "V6 Hemi", true, false, "Back Storage");
        Console.WriteLine(car.ToString() + "\n");

        Truck truck = new Truck(6, "yellow", false, 6, "V8", false, "Large Loads", true);
        Console.WriteLine(truck.ToString());

    }
}