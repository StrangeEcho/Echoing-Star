using System.Text;

public class RecursionIterationDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 5 Recursion & Iteration GP\n");
        Console.WriteLine("Iterative Countdown from 10:");
        IterativeCountdown(10);
        Console.WriteLine("\n\nRecursive Countdown from 10:");
        RecursiveCountdown(10);
        Console.WriteLine("\n\nIterative Name Reverse:");
        Console.WriteLine(IterativeNameReverse("Ruben Thomas"));
        Console.WriteLine("\nRecursive Name Reverse:");
        Console.WriteLine(RecursiveNameReverse("Ruben Thomas"));
    }
    
    private static void IterativeCountdown(int startNum)
    {
        for (int i = startNum; i > 0; i--)
        {
            Console.Write(i + ", ");
        }
        Console.Write("Blastoff!");
    }
    
    private static void RecursiveCountdown(int startNum)
    {
        if (startNum == 0)
        {
            Console.Write("Blastoff!");
        }
        else
        {
            Console.Write(startNum + ", ");
            RecursiveCountdown(startNum - 1);
        }
    }

    private static string IterativeNameReverse(string name)
    {
        StringBuilder reverseName = new StringBuilder();
        char[] strChars = name.ToCharArray();
        for (int i = name.Length - 1; i >= 0; i--)
        {
            reverseName.Append(strChars[i]);
        }
        return reverseName.ToString();
    }
    
    private static string RecursiveNameReverse(string name)
    {
        if (name.Length == 0)
        {
            return "";
        }
        else
        {
            return RecursiveNameReverse(name.Substring(1)) +
                   name.Substring(0, 1);
        }
    }
}