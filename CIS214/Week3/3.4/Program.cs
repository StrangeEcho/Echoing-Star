/*****
* name: Ruben Thomas
* date: 5.23.2024
* assignment: CIS214 Week 3 GP - Passinbg Arrays and Lists
*/

using System;
using System.Collections.Generic;

public class PassingArrayas {
    static void  Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 3 GP Passing Arrays and Lists\n");

        Console.WriteLine("Processing grades using an array:");
        Console.WriteLine("How many grades will you enter? ");
        string? val = Console.ReadLine();
        int gradeCount = Convert.ToInt32(val);

        int[] gradesArr = GetGrades(gradeCount);

        int avg = AverageGrades(gradesArr);
        Console.WriteLine("The average of the grades you entered is: {0}", avg);

        Console.WriteLine("Processing grades using a List:");
        List<int> gradesList = GetGrades();

        avg = AverageGrades(gradesList);

        Console.WriteLine("The average of the grades you entered is: {0}", avg);   
    }

    public static int[] GetGrades(int count) {
        int[] grades = new int[count];

        for (int i=0; i<count; i++) {
            Console.WriteLine("Please enter a grade: ");
            string? val = Console.ReadLine();
            grades[i] = Convert.ToInt32(val);
        }
        return grades; 
    }

    public static List<int> GetGrades() {
        List<int> grades = new List<int>();

        int grade = -1;
        do {
            Console.WriteLine("Please enter a grade (-1 to quit): ");
            string? val = Console.ReadLine();
            grade = Convert.ToInt32(val);

            if (grade > 0) {
                grades.Add(grade);
            }
        } while (grade> 0);
        return grades;
    }
    public static int AverageGrades(int[] grades) {
        int total = 0;

        foreach (int grade in grades) {
            total += grade;
        }
        return total / grades.Length;
    }

    public static int AverageGrades(List<int> grades) {
        int total = 0;

        foreach(int grade in grades) {
            total += grade;
        }
        return total / grades.Count;
    }
}