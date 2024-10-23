/*****
 * name: Ruben Thomas
 * date: 5.15.2024
 * assignment: CIS214 Week 1 PA - Classes, Objects, Methods, and Strings
 */

using System;

public class ClassObjMethStr
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - CIS214 Week 1 PA - Classes, Objects, Methods, and Strings");

        Employee emp1 = new Employee("John", "Doe", 1500);
        Employee emp2 = new Employee("Jane", "Smith", 800);


        Console.WriteLine("Initial Employee Information");
        PrintEmployeeInformation(emp1);
        PrintEmployeeInformation(emp2);

        Console.WriteLine();

        emp1.FirstName = "James";
        emp2.LastName = "Smith";
        emp1.UpdateSalary(2000);
        emp2.UpdateSalary(1200);

        Console.WriteLine("Updated Employee Information");
        PrintEmployeeInformation(emp1);
        PrintEmployeeInformation(emp2);
    }

    static void PrintEmployeeInformation(Employee employee)
    {
        Console.WriteLine("Name: {0} {1}", employee.FirstName, employee.LastName);
        Console.WriteLine("Monthly Salary: {0:F2}", employee.Salary);
    }
}