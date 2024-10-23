/*****
 * name: Ruben Thomas
 * date: 6.7.2024
 * assignment: CIS214 Week 5 GP - First Inheritance
 *
 */

public class Rectangle : Shape
{
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(string color, int length, int width) : base(color)
    {
        Length = length;
        Width = width;
    }

    public override void PrintShape()
    {
        Console.WriteLine(
            "This is a Rectangle.\nColor: {0}\nLength: {1}\nWidth: {2}\n", Color, Length, Width
        );
    }
}