public class Car {
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string BodyStyle { get; set; }
    public Engine EngineInfo { get; set; }
    public List<Tire> Tires { get; }

    public Car (
        string make, 
        string model, 
        string color, 
        string bodystyle,
        Engine engine 
    ) {
        Make = make;
        Model = model;
        Color = color;
        BodyStyle = bodystyle;
        EngineInfo = engine;
        Tires = new List<Tire>(); 
    }

    public override string ToString() {
        string ret =  $"Make: {Make}\nModel: {Model}\nColor: {Color}\nBody Style {BodyStyle}\nEngine: {EngineInfo}\nTires:\n";
        for (int i = 0; i < Tires.Count(); i++) {
            ret += $"\tTire {i + 1}:\n{Tires[i].ToString()}\n";
        }
        return ret;
    }

    public void AddTire(Tire tire) {
        Tires.Add(tire);
    }

    public void AddTire(string manafacturer, string size, int minpressure, int maxpressure, string tiretype) {
        Tires.Add(new Tire(manafacturer, size, minpressure, maxpressure, size));
    }

    public string GetInfo() {
        return $"{ToString()}\nEngine Cylinder Count: {EngineInfo.Cylinders}\nFuel Injected: {EngineInfo.FuelInjected}\nTire Count: {Tires.Count()}";

    }


}