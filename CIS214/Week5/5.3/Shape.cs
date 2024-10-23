/*****
 * name: Ruben Thomas
 * date: 6.7.2024
 * assignment: CIS214 Week 5 GP - First Inheritance
 *
 */

public class Shape
{
    public string Color { get; set; }

    public Shape(String color)
    {
        Color = color;
    }

    public virtual void PrintShape()
    {
        Console.WriteLine("The shape's color is {0}.\n", Color);
    }
}