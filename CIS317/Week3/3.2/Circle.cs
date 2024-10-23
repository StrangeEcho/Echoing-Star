public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string fillColor, string lineColor, double radius) : base(fillColor, lineColor)
    {
        Radius = radius;
    }

    public override string AreaFormula()
    {
        return "Pi times the radius squared (π * r^2)";
    }

    public override double Area()
    {
        return Math.PI * (Radius * Radius);
    }
}