public class Door
{
    private int Width;
    private string Color;

    public Door(int width, string color)
    {
        Width = width;
        Color = color; 
    }

    public override string ToString()
    {
        return $"Door - Width: {Width}, Color: {Color}";
    }
}