/*****
* name: Ruben Thomas
* date: 6.2.2024
* assignment: CIS214 Week 4 PA - User Entry of Age
*
* Main application (program) class.
* 
* In this application we will be asking the user to enter their age
* and handling any errors respectively depending on certain factors
*/

using System;

public class UserAge {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 4 PA - User Entry of Age\n");

        bool cont = true;

        do {
            try {
                Console.Write("Please enter your age: ");
                string? val = Console.ReadLine();
                int age = Convert.ToInt32(val);

                if (age < 1 || age > 100) {
                    throw new ArgumentOutOfRangeException("Enter an age between 1 and 100");
                }
                else {
                    Console.WriteLine("The age entered is: {0}", age);
                    cont = false;
                }
            }
            catch (FormatException e) {
                Console.WriteLine("\nString input was not of Int32\n{0}\n", e);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("\n{0}\n{1}\n", e.Message, e);
            }
        } while (cont);
    }
}