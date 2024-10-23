public abstract class Quadrilateral : Shape
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }

    public Quadrilateral(string fillColor, string lineColor,
        double length1, double length2) : base(fillColor, lineColor)
    {
        Length1 = length1;
        Length2 = length2;
    }

    public abstract override string AreaFormula();

    public override double Area()
    {
        return Length1 * Length2;
    }
}