using System;

public class Employee
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public double Salary { get; private set; }

    public void UpdateSalary(double newSalary)
    {
        if (newSalary >= 1000)
        {
            Salary = newSalary;
        }
    }

    public Employee(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }
}