using System;
using System.IO;

public class OperatorDataTypes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - Week 1 GP Operators & Data Types\n");

        int intVal1 = 0;
        int intVal2 = 5;
        int intVal3 = 5;

        if (intVal1 == intVal3) // Equality
        {
            Console.WriteLine("{0:D} is equal to {1:D}", intVal2, intVal3);
        }

        if (intVal1 != intVal3) // Inequality
        {
            Console.WriteLine("{0:D} is not equal to {1:D}", intVal1, intVal3);
        }

        if (intVal1 < intVal3) // Less than
        {
            Console.WriteLine("{0:D} is less than to {1:D}", intVal1, intVal3);
        }

        if (intVal2 > intVal1) // Greater than 
        {
            Console.WriteLine("{0:D} is greater than to {1:D}", intVal2, intVal1);
        }

        if (intVal2 <= intVal3) // Less than or equal to
        {
            Console.WriteLine("{0:D} is less than or equal to {1:D}", intVal2, intVal3);
        }

        if (intVal2 >= intVal3) // Greater than or equal to
        {
            Console.WriteLine("{0:D} is greater than or equal to {1:D}", intVal2, intVal3);
        }

        Console.WriteLine("Enter an integer value: ");
        string? val = Console.ReadLine();
        intVal1 = Convert.ToInt32(val);
        Console.WriteLine("Enter a second integer value: ");
        val = Console.ReadLine();
        intVal2 = Convert.ToInt32(val);
        int sum = intVal1 + intVal2;
        Console.WriteLine("The sum of {0:D} and {1:D} is {2:D}", intVal1, intVal2, sum);

        Console.WriteLine("Enter a floating point value: ");
        val = Console.ReadLine();
        double fltValue1 = Convert.ToDouble(val);
        Console.WriteLine("Enter a second floating point value: ");
        val = Console.ReadLine();
        double fltValue2 = Convert.ToDouble(val);
        double total = fltValue1 + fltValue2;
        Console.WriteLine("The sum of {0:F3} and {1:F3} is {2:F3}", fltValue1, fltValue2, total);
    }
}