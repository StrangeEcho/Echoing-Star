/*****
* name: Ruben Thomas
* date: 5.20.2024
* assignment: CIS214 Week 2 PA - Loops & Calculations
*/ 

using System;

class LoopsCalculation {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 2 PA Loops & Calculation\n\n");

        Console.WriteLine("Enter an integer to sum up to: ");
        string? val = Console.ReadLine();
        int max = Convert.ToInt32(val);

        Console.WriteLine("Calculating the sum of integers 1-{0}:", max);
        int sum = 0;
        for (int i=1; i<=max; i++) {
            sum += i;
            Console.WriteLine("Running total so far: {0}", sum);
        }
        
        Console.WriteLine(); // Blank line
        
        Console.WriteLine("Adding integers entered:\n");

        sum = 0;
        int count = 0;
        int sent = 0;
        while (sent != -1) {
            count += 1;
            Console.WriteLine("Enter an integer (-1 to quit): ");
            val = Console.ReadLine();
            sent = Convert.ToInt32(val);
            sum += sent;

            if (sent != -1 ) {
                Console.WriteLine("Running total: {0}", sum);
            }
        }
        Console.WriteLine("Total Sum: {0}", sum);
        Console.WriteLine("Integers entered: {0}", count);
    }
}