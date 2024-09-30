/*****
* name: Ruben Thomas
* date: 5.29.2024
* assignment: CIS214 Week 4 GP - System Generated Exceptions
*/

using System;

public class SystemExceptionDemo {

    public static int Quotient(int numerator, int denominator) {
        return numerator / denominator;
    }
    static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 4 GP - System Generated Exceptions");

        bool cont = true;

        do {
            try {
                Console.Write("Please enter an integer numerator: ");
                string? val = Console.ReadLine();
                int numerator = Convert.ToInt32(val);
                Console.Write("Please enter an integer denominator: ");
                val = Console.ReadLine();
                int denominator = Convert.ToInt32(val);

                int res = Quotient(numerator, denominator);
                Console.WriteLine("\nResult: {0} / {1} = {2}", numerator, denominator, res);
                cont = false;
            }
            catch (FormatException e) {
                Console.WriteLine("\nException: {0}", e);
                Console.WriteLine("You must enter integers. Please try again...");
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("\n {0}", e);
                Console.WriteLine("Zero is an invalid denominator. Please try again...");
            }
        } while (cont);

        Console.WriteLine("Heres what would have happened with zero exception handling:\n");
        Console.Write("Please enter an integer numerator: ");
        string? val2 = Console.ReadLine();
        int numerator2 = Convert.ToInt32(val2);
        Console.Write("Please enter an integer denominator: ");
        val2 = Console.ReadLine();
        int denominator2 = Convert.ToInt32(val2);
        int res2 = Quotient(numerator2, denominator2);

        Console.WriteLine("\nResult: {0} / {1} = {2}", numerator2, denominator2, res2);
    }    
}