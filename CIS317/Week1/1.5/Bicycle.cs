public class Bicycle : Vehicle {
    public int Gears { get; set; }
    public double SeatHeight { get; set; }
    public double TireSize { get; set; }

    public Bicycle (
        int wheels,
        string color,
        bool moving, 
        int seats,
        int gears, 
        double seatheight,
        double tiresize
    ) : base(wheels, color, moving, seats) {
        Gears = gears;
        SeatHeight = seatheight;
        TireSize = tiresize;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nGears: {Gears}\nSeat Height: {SeatHeight}\nTire Size: {TireSize}";
    }
}