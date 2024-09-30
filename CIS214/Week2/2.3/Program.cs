/*****
* name: Ruben Thomas
* date: 5.15.2024
* assignment: CIS214 Week 2 GP - Conditional Loops
*/ 

using System;

public class GradeCounts {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 2 GP Conditional Loops");

        Console.WriteLine("Looping using a while loop:");
        Console.Write("Enter a grade between 0 and 100 (-1 to stop): ");
        string? val = Console.ReadLine();
        int inVal = Convert.ToInt32(val);
        int passCount = 0;
        int failCount = 0;

        while (inVal != -1) {
            if (inVal >= 60) {
                passCount += 1;
            } 
            else {
                failCount += 1;
            }
            Console.Write("Enter a grade between 0 and 100 (-1 to stop): ");
            val = Console.ReadLine();
            inVal = Convert.ToInt32(val);
        }
        Console.WriteLine("Count of passing grades: {0}", passCount);
        Console.WriteLine("Count of failing grades: {0}", failCount);
        
        Console.WriteLine("Looping using a do-while loop:");
        passCount = 0;
        failCount = 0;

        do {
            Console.Write("Enter a grade between 0 and 100 (-1 to stop): ");
            val = Console.ReadLine();
            inVal = Convert.ToInt32(val);
            
            if (inVal >= 60) {
                passCount += 1;
            } 
            else if (inVal != -1) {
                failCount += 1;
            }
        } while (inVal != -1);
        
        Console.WriteLine("Count of passing grades: {0}", passCount);
        Console.WriteLine("Count of failing grades: {0}", failCount);
    }

}