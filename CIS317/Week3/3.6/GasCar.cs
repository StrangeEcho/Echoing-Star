public class GasCar : Car {
    public GasCar(string fuel, string engine) :
        base(fuel, engine) { }
    
    public GasCar(string engine) :
        base ("Regular Unleaded", engine) { }
    
    public void UpdateFuel(string fuel) {
        Fuel = fuel;
    }
}