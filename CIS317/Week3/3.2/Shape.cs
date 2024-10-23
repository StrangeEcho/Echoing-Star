public abstract class Shape
{
    public string FillColor { get; set; }
    public string LineColor { get; set; }

    public Shape(string fillColor, string lineColor)
    {
        FillColor = fillColor;
        LineColor = lineColor;
    }

    public abstract string AreaFormula();
    public abstract double Area();

    public override string ToString()
    {
        return
            $"Shapes Properties\nType: {GetType().Name}\nArea Formula: {AreaFormula()}\nArea {Area():F3}\nFill Color: {FillColor}\nLineColor: {LineColor}\n";
    }
}