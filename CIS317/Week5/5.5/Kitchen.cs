public class Kitchen
{
    //private access specifiers
    private string Style; 
    private string ApplianceBrand;

    public Kitchen(string style, string applianceBrand)
    {
        Style = style;
        ApplianceBrand = applianceBrand;
    }

    public override string ToString() // overwritten method
    {
        return $"Kitchen - Style: {Style}, Appliance Brand: {ApplianceBrand}";
    }
}