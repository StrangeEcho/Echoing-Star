public class AbstractionTest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 3 Abstraction GP\n");

        Shape shape = new Square("Orange", "Red", 5.0);
        Console.WriteLine(shape);
        shape = new Rectangle("Green", "Black", 5.5, 2.5);
        Console.WriteLine(shape);
        shape = new Rhombus("Purple", "Red", 1.7, 3);
        Console.WriteLine(shape);
        shape = new Circle("Blue", "Red", 3.4);
        Console.WriteLine(shape);

        Square square = new Square("Chartreuse", "Forest Green", 11.2);
        Console.WriteLine(square);
        Rectangle rect = new Rectangle("Grey", "Gray", 3.2, 5.5);
        Console.WriteLine(rect);
        Rhombus para = new Rhombus("Yellow", "Orange", 2.9, 4.7);
        Console.WriteLine(para);
        Circle circle = new Circle("Cyan", "Brown", 1.234);
        Console.WriteLine(circle);
    }
}