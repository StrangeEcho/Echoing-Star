/*****
 * name: Ruben Thomas
 * date: 5.15.2024
 * assignment: CIS214 Week 2 GP - Decisions & Logical Operators
 */

using System;

public class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas - Week 2 GP Decisions & Logical Operators\n");

        Console.WriteLine(
            "Conditional AND (&&):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}",
            "false && false", false && false,
            "false && true", false && true,
            "true && false", true && false,
            "true && true", true && true
        );

        Console.WriteLine(
            "Conditional OR (||):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}",
            "false || false", false || false,
            "false || true", false || true,
            "true || false", true || false,
            "true || true", true || true
        );

        Console.WriteLine(
            "Logical AND (&):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}",
            "false & false", false & false,
            "false & true", false & true,
            "true & false", true & false,
            "true & true", true & true
        );

        Console.WriteLine(
            "Logical OR (|):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}",
            "false | false", false | false,
            "false | true", false | true,
            "true | false", true | false,
            "true | true", true | true
        );

        Console.WriteLine(
            "Logical Exclusive OR (^):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}",
            "false ^ false", false ^ false,
            "false ^ true", false ^ true,
            "true ^ false", true ^ false,
            "true ^ true", true ^ true
        );

        Console.WriteLine(
            "Logical negation (!):\n{0}: {1}\n{2}: {3}",
            "!false", !false,
            "!true", !true
        );

        Console.Write("\nEnter an integer grade in range 0 - 100: ");
        string? val = Console.ReadLine();
        int grade = Convert.ToInt32(val);

        Console.WriteLine("Determining grade using if-else");
        if (grade >= 90)
        {
            Console.WriteLine("The grade entered is an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("The grade entered is a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("The grade entered is a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("The grade entered is a D");
        }
        else
        {
            Console.WriteLine("The grade entered is an F");
        }

        Console.WriteLine("Determining grade using switch");

        switch (grade / 10)
        {
            case 9:
            case 10:
                Console.WriteLine("The grade entered is an A");
                break;
            case 8:
                Console.WriteLine("The grade entered is a B");
                break;
            case 7:
                Console.WriteLine("The grade entered is a C");
                break;
            case 6:
                Console.WriteLine("The grade entered is a D");
                break;
            default:
                Console.WriteLine("The grade entered is an F");
                break;
        }
    }
}