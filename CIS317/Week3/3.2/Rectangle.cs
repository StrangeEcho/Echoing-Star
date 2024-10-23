public class Rectangle : Quadrilateral
{
    public Rectangle(string fillColor, string lineColor, double length1, double length2) :
        base(fillColor, lineColor, length1, length2)
    {
    }

    public override string AreaFormula()
    {
        return "Length times Width (l * w).";
    }
}