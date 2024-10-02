public class Vehicle {
    public int Wheels { get; set; }
    public string Color { get; set; }
    public bool Moving {get; set; }
    public int Seats { get; set; }

    public Vehicle(
        int wheels, 
        string color, 
        bool moving, 
        int seats
    ) {
        Wheels = wheels;
        Color = color; 
        Moving = moving;
        Seats = seats;
    }

    public override string ToString() {
        return $"Wheels: {Wheels}\nColor: {Color}\nMoving: {Moving}\nSeats: {Seats}";
    }
}