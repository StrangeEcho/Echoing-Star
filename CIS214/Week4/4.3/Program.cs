/*****
* name: Ruben Thomas
* date: 6.2.2024
* assignment: CIS214 Week 4 GP - User Generated Exceptions
*/
using System;

public class UserExceptions { 
    public static int Quotient(int numerator, int denominator) {
        if (denominator == 0) {
            throw new Exception("Division by zero is not allowed!");
        }
        return numerator / denominator;
    }

    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 4 GP - User Generated Exceptions\n");

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
            catch(Exception e) {
                Console.WriteLine("\nUser-Generated Exception: {0}", e);
                Console.WriteLine("{0} Please try again.", e.Message);
            }
        } while (cont);
    }
}