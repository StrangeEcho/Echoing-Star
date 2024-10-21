public class MainProgram {
    static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 3 Constructors & Access Specifiers Performance Assessment\n\n");

        ParkingLot parkingLot = new ParkingLot();

        ElectricCar electricCar = new ElectricCar();
        
        GasCar gasCar = new GasCar("4 Cyllinder");
        GasCar gasCar1 = new GasCar("Premium Unleaded", "V6 DOHC");

        parkingLot.Cars.Add(electricCar);
        parkingLot.Cars.Add(gasCar);
        parkingLot.Cars.Add(gasCar1);

        Console.WriteLine("Cars in the Parking Lot:\n");
        PrintParkingLot(parkingLot);
    }

    private static void PrintParkingLot(ParkingLot parkinglot) {
        foreach (Car car in parkinglot.Cars) {
            Console.WriteLine(car.ToString() + "\n");
        }
    }
}