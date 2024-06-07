// Thank you Davyan

/*******************************************************************
* Name: Ruben Thomas
* Date: June 7, 2024
* Assignment CIS214 Week 5 GP – First Inheritance BONUS
*/
using System;
public class PersonClass
{
    public string PName { get; set; }
    public string DOB { get; }
    public long SSN { get; }
    public string pheight { get; set; }
    public string pweight { get; set; }

    public PersonClass(string dt, long num)
    {
        DOB = dt; SSN = num;
    }

    public uint get_age()
    {
        DateTime curDate = DateTime.Now;
        DateTime birthDate = Convert.ToDateTime(DOB);

        TimeSpan diff = (curDate - birthDate);
        return Convert.ToUInt32(diff.TotalDays/365);
    }

}

public class StudentClass : PersonClass
{
    public string univ_name { get; set; }
    public string umajor { get; set; }
    public double GPA { get; set; }
    public string DOGR { get; set; }

    public StudentClass(string dt, long num, string unm) : base(dt, num)
    {
        univ_name = unm;
    }

    public void PrintRecord()
    {
        Console.WriteLine("\n Name: {0}\n Major {1}\n GPA: {2}\n", PName, umajor, GPA);
    }

}
public class PersonDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - Week 5 GP - Inheritance Bonus\n");

        PersonClass p = new PersonClass("June 2, 1997", 123654876);
        p.PName = "TJ Watts";
        Console.WriteLine("{0} is {1} years old", p.PName, p.get_age());

        // Update the objects' properties
        StudentClass s = new StudentClass("January 1, 2001", 123456789, "Harvard");
        s.PName = "Jeff Bezos";
        s.umajor = "EET";
        s.GPA = 4.01;
        s.PrintRecord();

        // Demonstrate calling a base class method from a derived class object
        Console.WriteLine("Student {0} is {1} years old", s.PName, s.get_age());
    }
}
