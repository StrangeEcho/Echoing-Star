/*****
* name: Ruben Thomas
* date: 6.7.2024
* assignment: CIS214 Week 5 GP - Inheritance & Overriding
*
*/

public class Circle : Shape {
    public int Radius { get; set; }

    public Circle(String color, int radius) : base(color) {
        Radius = radius;
    }

    public override void PrintShape() {
        Console.WriteLine(
            "This is a Circle.\nColor: {0}\nRadius: {1}",
            Color, Radius
        );
    }
}