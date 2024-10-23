public class Car
{
    public string Fuel { get; protected set; }
    public string Engine { get; protected set; }

    protected Car(string fuel, string engine)
    {
        Fuel = fuel;
        Engine = engine;
    }

    public override string ToString()
    {
        return $"Car Type : {GetType()}\n\tEngine Type: {Engine}\n\tFuel Type: {Fuel}";
    }
}