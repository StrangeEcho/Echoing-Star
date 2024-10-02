public class MainProgram {
    static void Main(string[] args) {
        
        Engine engine = new Engine(4, "Unleaded", false);
        
        Car car = new Car("Toyota", "Rav4", "White", "Sport Body", engine);

        Tire tire = new Tire("Firestone", "185/60R13", 30, 40, "Suv-Tire");
        car.AddTire(tire);

        car.AddTire("Using other method to add tire random manafacturer", "185/60R13",
        30, 40, "Suv-Tire using other method");

        Console.WriteLine("GetInfo() Method\n" + car.GetInfo() + "\n\nToString() Method");
        Console.WriteLine(car.ToString());
    }
}