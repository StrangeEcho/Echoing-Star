public class Truck : Motorized { 
    public string Load { get; set; }
    public bool Towing { get; set; }

    public Truck(
        int wheels, 
        string color, 
        bool moving,
        int seats, 
        string engine, 
        bool automatic,
        string load, 
        bool towing
    ) : base(
        wheels,
        color,
        moving,
        seats,
        engine,
        automatic
    ) {
        Load = load;
        Towing = towing; 
    }

    public override string ToString() {
        return $"{base.ToString()}\nLoad: {Load}\nTowing: {Towing}";
    }
}