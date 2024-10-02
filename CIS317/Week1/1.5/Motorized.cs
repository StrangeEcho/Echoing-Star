public class Motorized : Vehicle { 
    public string Engine { get; set; }
    public bool Automatic { get; set; }

    public Motorized(
        int wheels, 
        string color, 
        bool moving, 
        int seats,
        string engine, 
        bool automatic
    ) :  base(wheels, color, moving, seats) {
        Engine = engine;
        Automatic = automatic;
    }

    public override string ToString() {
        return $"Wheels: {base.Wheels}\nColor: {base.Color}\nMoving: {base.Moving}\nSeats: {base.Seats}\nEngine: {Engine}\nAutomatic: {Automatic}";
    }

}