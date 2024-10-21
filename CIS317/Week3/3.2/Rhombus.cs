public class Rhombus : Quadrilateral {
    public Rhombus(string fillColor, string lineColor, double d1, double d2) :
        base(fillColor, lineColor, d1, d2) { }

    public override string AreaFormula()
    {
        return "One-half Diagonal 1 times Diagonal 2 (d1 * d2)/2";
    }

    public override double Area()
    {
        return base.Area() / 2;
    }
}