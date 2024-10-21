public class Square : Quadrilateral {
    public Square (string fillColor, string lineColor, double length) :
        base(fillColor, lineColor, length, length) { }
    public override string AreaFormula()
    {
        return "Length squares (l^2)";
    }
}