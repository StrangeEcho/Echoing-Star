/*****
* name: Ruben Thomas
* date: 6.4.2024
* assignment: CIS214 Week 5 GP - First Inheritance
*
* Main application (program class.
* In this application we will demonstrate the concept of inheritance
* by instantiating Shape and Rectangle objects and demonstrating the
* use of base class methods in a dervices class instantiated object.
*/


public class Shape {
    public string Color { get; set; }

    public Shape(String color) {
        Color = color;
    }

    public void PrintShape() {
        Console.WriteLine("The Shape's color is {0}.\n", Color);
    }
}

public class Rectangle : Shape {
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(string color, int length, int width) : base(color) {
        Length = length;
        Width = width;
    }

    public void PrintRectangle() {
        Console.WriteLine(
            "This is a Rectangle\nColor: {0}\n Length: {1}\n Width: {2}\n",
            Color, Length, Width
        );
    }
}

public class ShapeDemo {
    static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 5 GP - First Inheritance\n");

        Shape s = new Shape("Blue");
        Rectangle r = new Rectangle("Orange", 5, 10);

        s.PrintShape();
        r.PrintRectangle();

        r.PrintShape();

        s.Color = "Green";

        r.Color = "Red";
        r.Length = 2;
        r.Width = 4;

        s.PrintShape();
        r.PrintRectangle();
    }
}