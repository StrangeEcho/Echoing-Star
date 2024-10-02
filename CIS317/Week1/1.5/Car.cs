public class Car : Motorized { 
    public bool SunRoof { get; set; }
    public string Storage { get; set; }

    public Car(
        int wheels, 
        string color, 
        bool moving,
        int seats, 
        string engine, 
        bool automatic,
        bool sunroof, 
        string storage
    ) : base(
        wheels,
        color,
        moving,
        seats,
        engine,
        automatic
    ) {
        SunRoof = sunroof;
        Storage = storage; 
    }

    public override string ToString() {
        return $"{base.ToString()}\nSun Roof: {SunRoof}\nStorage: {Storage}";
    }
}