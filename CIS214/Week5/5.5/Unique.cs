/*****
* name: Ruben Thomas
* date: 6.7.2024
* assignment: CIS214 Week 5 - Final Practical Exam
*
*/
using System;
using System.Collections;


public class UniqueNumbers {
    private List<int> Unique { get; set; }
    
    public UniqueNumbers() {
        Unique = new List<int>();
    }

    public void GetNumbers() {
        while (Unique.Count != 5) {
            try {
                Console.WriteLine("Enter an integer (0-100): ");
                string? val = Console.ReadLine();
                int num = Convert.ToInt32(val);

                if (num < 0 || num > 100) {
                    throw new ArgumentOutOfRangeException(); 
                }

                if (!Unique.Contains(num)) {
                    Unique.Add(num);
                }
            }
            catch (FormatException e) {
                Console.WriteLine("Number entered was not of Int32\n{0}", e);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Number was not between 0-100\n{0}", e);
            }
        }
    }

    public int LargestNumber() {
        int largest = 0;

        foreach (int num in Unique) {
            if (num > largest) {
                largest = num;
            }
        }
        return largest;
    }
    public int SmallestNumber() {
        int smallest = 100;

        foreach (int num in Unique) {
            if (num < smallest) {
                smallest = num;
            }
        }
        return smallest;
    }

    public int SumOfNumbers() {
        int sum = 0;

        foreach (int num in Unique) {
            sum += num;
        }
        return sum;
    }

    public int AverageOfNumbers() {
        int sum = SumOfNumbers();

        return sum / Unique.Count;
    }
    public void FirstLastDivision() {
        try {
            if (Unique.Count > 0) {

                float quotient = (float)Unique[Unique.Count - 1] / Unique[0];
                Console.WriteLine("Last divided by first: {0}", quotient);
            }
            else {
                Console.WriteLine("Cannot perform division. The list is empty.");
            }
        }
        catch (DivideByZeroException e) {
            Console.WriteLine("Cannot divide by 0\n{0}", e);
        }
    }
}