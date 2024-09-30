/*****
* name: Ruben Thomas
* date: 5.26.2024
* assignment: CIS214 Week 3 PA - Calculations & Unique Numbers
*/ 

using System;
using System.Collections.Generic;

public class CalculationsUniqueNumbers {
    static void Main(string[] args) {
        List<int> numbers = new List<int>();

        Console.WriteLine("\nRuben Thomas - Week 3 PA Calculations & Unique Numbers\n");
        for (int i=0; i<=9; i++) {
            Console.WriteLine("Please enter an integer value: ");
            string? val = Console.ReadLine();
            numbers.Add(Convert.ToInt32(val));
        }
        displayInfo(numbers);
        displayUniqueInfo(numbers);
    }

    public static void displayInfo(List<int> numbers) {
        int sum = 0;

        Console.WriteLine("The count of integers entered is: 10");

        foreach (int num in numbers) {
            sum += num;
        }
        Console.WriteLine("Sum of integers: {0}", sum);
        Console.WriteLine("Average of integers: {0}", sum / 10);

    }
    public static void displayUniqueInfo(List<int> numbers) {
        List<int> uniqueList = new List<int>();
        foreach (int num in numbers) {
            if (!uniqueList.Contains(num)) {
                uniqueList.Add(num);
            }
        }
        int sum = 0;
        Console.WriteLine("\nCount of unique integers: {0}", uniqueList.Count);
        foreach(int num in uniqueList) {
            sum += num;
        }
        Console.WriteLine("Sum of unique integers: {0}", sum);
        Console.WriteLine("Average of unique numbers: {0}", sum / uniqueList.Count);
    }
}