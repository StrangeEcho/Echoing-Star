/*****
* name: Ruben Thomas
* date: 6.7.2024
* assignment: CIS214 Week 5 - Final Practical Exam
*
*/

public class App {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Final Practical Exam");

        UniqueNumbers un = new UniqueNumbers();

        un.GetNumbers();

        Console.WriteLine("The largest number entered: {0}", un.LargestNumber());
        Console.WriteLine("The smallest number entered: {0}", un.SmallestNumber());
        Console.WriteLine("The sum of numbers entered: {0}", un.SumOfNumbers());
        Console.WriteLine("The average of numbers entered: {0}", un.AverageOfNumbers());
        un.FirstLastDivision();
    }
}