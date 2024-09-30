/************
* Name: Ruben Thomas
* Assignment: 1.3 Displaying Text
*/

public class DisplayText { 
    static void Main(string[] args) {
        Console.WriteLine("Hello, Ruben! Welcome to C# programming");
        
        Console.WriteLine();

        Console.WriteLine("A string followed by a newline. \n" +
            "A string following the new line\n" +
            "Decimal (integer value) {0:D}\n" + 
            "Floating poiunt number 3.1315 to 2 decimales: {1:F2}\n" +
            "Floating point number 1.999 to 2 decimals (rounded): {2:F2}\n",
            4, 3.1415, 1.999
        );
    }
}