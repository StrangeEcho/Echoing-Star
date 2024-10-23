/*****
 * name: Ruben Thomas
 * date: 5.15.2024
 * assignment: CIS214 Week 1 PA - IO & Operators
 */

using System;

public class IoOperators
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - Week 1 PA IO & Operators");

        Console.WriteLine("Enter an integer value: ");
        string? val = Console.ReadLine();
        int int1 = Convert.ToInt32(val);
        Console.WriteLine("Enter an another integer value: ");
        string? val1 = Console.ReadLine();
        int int2 = Convert.ToInt32(val1);

        Console.WriteLine("The sum of {0} and {1} is {2}", int1, int2, int1 + int2);
        if (int1 != int2)
        {
            Console.WriteLine("{0} is not equal to {1}", int1, int2);
        }
        else if (int1 == int2)
        {
            Console.WriteLine("{0} is equal to {1}", int1, int2);
        }

        if (int1 < int2)
        {
            Console.WriteLine("{0} is less than {1}", int1, int2);
        }
        else if (int1 > int2)
        {
            Console.WriteLine("{0} is greater than {1}", int1, int2);
        }

        if (int1 <= int2)
        {
            Console.WriteLine("{0} is less than or equal to {1}", int1, int2);
        }
        else
        {
            Console.WriteLine("{0} is greater than or equal to {1}", int1, int2);
        }

        Console.WriteLine();

        Console.WriteLine("Enter a floating point value: ");
        double float1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter another floating point value: ");
        double float2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The sum of {0} and {1} is {2}", float1, float2, float1 + float2);
        if (int1 != int2)
        {
            Console.WriteLine("{0} is not equal to {1}", float1, float2);
        }
        else if (int1 == int2)
        {
            Console.WriteLine("{0:F2} is equal to {1:F2}", float1, float2);
        }

        if (int1 < int2)
        {
            Console.WriteLine("{0:F2} is less than {1:F2}", float1, float2);
        }
        else if (int1 > int2)
        {
            Console.WriteLine("{0:F2} is greater than {1:F2}", float1, float2);
        }

        if (int1 <= int2)
        {
            Console.WriteLine("{0:F2} is less than or equal to {1:F2}", float1, float2);
        }
        else
        {
            Console.WriteLine("{0:F2} is greater than or equal to {1:F2}", float1, float2);
        }
    }
}