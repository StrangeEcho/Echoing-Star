/*****
* name: Ruben Thomas
* date: 5.23.2024
* assignment: CIS214 Week 3 GP - Methods, Statics, Class Math
*

* Main application (program) class.
* In this application we will demonstate the creation and use of 
* user-defined methods, static methods, method overload, and the 
* use of the Math class
*/ 
using System;

public class StaticsMethodsMath {

    private static string Label = "The maximum value is: ";

    static void Main(string[] args) {
    
        Console.WriteLine("\nRuben Thomas - Week 3 GP Methods, Statics, class Math\n");

        Console.Write("Enter 3 floating-point values seperated by spaces: ");
        string? val = Console.ReadLine();

        if (!string.IsNullOrEmpty(val)) {
            string[] vals = val.Split();
            double f1 = double.Parse(vals[0]);
            double f2 = double.Parse(vals[1]);
            double f3 = double.Parse(vals[2]);

            DisplayMessage(MaxOfThree(f1, f2, f3));
        }

        Console.WriteLine("Enter 3 integer values seperated by spaces: ");
        val = Console.ReadLine();
        if (!string.IsNullOrEmpty(val)) {
            string[] vals = val.Split();
            int i1 = int.Parse(vals[0]);
            int i2 = int.Parse(vals[1]);
            int i3 = int.Parse(vals[2]);

            DisplayMessage(MaxOfThree(i1, i2, i3));
        }
    }
    public static void DisplayMessage(double val) {
        Console.WriteLine("{0}{1}", Label, val);
    }

    public static void DisplayMessage(int val) {
        Console.WriteLine("{0}{1}", Label, val);
    }

    public static double MaxOfThree(double x, double y, double z) {
        double maxValue = Math.Max(x, y);
        
        return Math.Max(maxValue, z);
    }

    public static int MaxOfThree(int x, int y, int z) {
        int maxValue = Math.Max(x, y);
        
        return Math.Max(maxValue, z);
    }
}