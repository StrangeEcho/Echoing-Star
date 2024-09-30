/*****
* name: Ruben Thomas
* date: 6.2.2024
* assignment: CIS214 Week 4 PA - Account Balance Calculations
*
* Main application (program) class.
* In this application we will ask the user for a starting balance to take away from and 
* to add to as well. We will start a loop that has a control of 0 to exit and indefinintly take and 
* add to the starting balance and print out the ending balance at the end of the program
*/

using System;

public class AccountBalanceCalculations{
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 4 PA - Account Balance Calculations\n");

        Console.Write("Please enter your starting balance: ");
        string? val = Console.ReadLine();
        double StartingBalance = Convert.ToDouble(val);

        while (true) {
            try {
                Console.Write("Enter an amount (negatives possible) to add to your balance: ");
                val = Console.ReadLine();
                double amt = Convert.ToDouble(val);

                if (amt == 0) {
                    break;
                }
                
                if (amt + StartingBalance < 0) {
                    throw new Exception("Amount will cause account balance to be negative");
                }
                StartingBalance += amt;
                Console.WriteLine("New updated balance: {0}", StartingBalance);
            }
            catch (FormatException e) {
                Console.WriteLine("\nInput was not of Double. Try again...\n{0}\n", e);
            }
            catch (Exception e) {
                Console.WriteLine("\n{0}\n{1}\n", e.Message, e);
            }
        }
        Console.WriteLine("The Final balance: {0}", StartingBalance);
    }
}