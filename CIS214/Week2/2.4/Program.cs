/*****
 * name: Ruben Thomas
 * date: 5.15.2024
 * assignment: CIS214 Week 2 GP - Counter Controlled Loops
 */

using System;

public class CounterControlledLoops
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas - Week 2 GP Counter Controlled Loops");

        int c = 5;
        Console.WriteLine("Value of c before prefix increment: {0}", c);
        Console.WriteLine("Value of c with prefix increament: {0}", ++c);
        Console.WriteLine("Value of c after prefix increment: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before prefix decrement: {0}", c);
        Console.WriteLine("Value of c with prefix decrement: {0}", --c);
        Console.WriteLine("Value of c after prefix decrement: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before suffix increment: {0}", c);
        Console.WriteLine("Value of c with suffix increament: {0}", c++);
        Console.WriteLine("Value of c after suffix increment: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before suffix decrement: {0}", c);
        Console.WriteLine("Value of c with suffix decrement: {0}", c--);
        Console.WriteLine("Value of c after suffix decrement: {0}\n", c);

        Console.WriteLine("Counter-Controlled while Loop demonstration");
        int wcnt1 = 1;

        while (wcnt1 <= 10)
        {
            Console.Write("{0} ", wcnt1);
            wcnt1++;
        }

        Console.WriteLine("\n\n For Loop demonstration");
        for (int cnt = 1; cnt <= 10; cnt++)
        {
            Console.Write("{0} ", cnt);
        }

        Console.WriteLine("\n\n while loop countdown");
        int wcnt2 = 10;

        while (wcnt2 >= 0)
        {
            Console.Write("{0} ", wcnt2);
            wcnt2--;
        }

        Console.WriteLine("\n\n for loop countdown");
        for (int cnt = 10; cnt >= 0; cnt--)
        {
            Console.Write("{0} ", cnt);
        }
    }
}