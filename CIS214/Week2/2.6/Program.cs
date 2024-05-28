/*****
* name: Ruben Thomas
* date: 5.20.2024
* assignment: CIS214 Week 2 PA - Smallest Number
*/ 

using System;

public class SmallestNumber {
    static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 2 PA Smallest Number");

        Console.WriteLine("Finding the smallest Value:");
        Console.WriteLine("How many integers would you like to enter: ");
        string? val = Console.ReadLine();
        int max = Convert.ToInt32(val);

        int smallest = 0;
        for (int i=0; i<max; i++) {
            Console.WriteLine("Enter an integer Value");
            val = Console.ReadLine();
            int num = Convert.ToInt32(val);
            if (i == 0) {
                smallest = num;
            }
            else if (num < smallest) {
                smallest = num;
            }
        }
        Console.WriteLine("The smallest value that was entered is: {0}", smallest);
    }
}