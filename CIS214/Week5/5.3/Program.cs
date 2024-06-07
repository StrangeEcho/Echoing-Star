/*****
* name: Ruben Thomas
* date: 6.7.2024
* assignment: CIS214 Week 5 GP - Inheritance & Overriding
*
*/

public class App {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 5 GP - Inheritance & Overriding");

        Shape s = new Shape("Blue");
        Rectangle r = new Rectangle("Orange", 5, 10);
        Circle c = new Circle("Yellow", 2);

        s.PrintShape();
        r.PrintShape();
        c.PrintShape();

        s.Color = "Green";

        r.Color = "Red";
        r.Length = 2;
        r.Width = 4;

        c.Color = "Purple";
        c.Radius = 12;

        s.PrintShape();
        r.PrintShape();
        c.PrintShape();
    }
}