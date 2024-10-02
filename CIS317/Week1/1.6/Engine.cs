public class Engine {
    public int Cylinders { get; set; }
    public string GasType { get; set; }
    public bool FuelInjected {get; set; }

    public Engine(int cylinders, string gastype, bool fuelinjected) {
        Cylinders = cylinders;
        GasType = gastype;
        FuelInjected = fuelinjected;
    }

    public override string ToString() {
        return $"Cylinders: {Cylinders}\nGas Type: {GasType}\nFuel Injected: {FuelInjected}";
    }
}