/*****
* name: Ruben Thomas
* date: 5.23.2024
* assignment: CIS214 Week 3 GP - Passinbg Arrays and Lists

* This program class will take 10 integers from user input
* and determine the max and min of the whole collection
* while displaying all inputted elements
*/

using System;
using System.Collections.Generic;


public class MidTermPractical
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a integer value: ");
            string? val = Console.ReadLine();
            numbers.Add(Convert.ToInt32(val));
        }

        Console.WriteLine("Index\tValue");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine("{0}\t{1}", i, numbers[i]);
        }

        displayMaxMin(numbers);
    }

    public static void displayMaxMin(List<int> numbers)
    {
        int maxNumber = numbers[0];
        int minNumber = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }

            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        Console.WriteLine("Max Value: {0}", maxNumber);
        Console.WriteLine("Min Value: {0}", minNumber);
    }
}