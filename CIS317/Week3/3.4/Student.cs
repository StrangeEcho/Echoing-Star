using System.Runtime.CompilerServices;

public class Student : Person
{
    public int GradYear { get; private set; }

    public Student(string name, double age, string email, int gradYear) :
        base(name, age, email)
    {
        if (gradYear > 1900)
        {
            GradYear = gradYear;
        }
        else
        {
            gradYear = 1900;
        }
    }

    public void UpdateGradYear(int gradYear)
    {
        if (gradYear > 1900)
        {
            GradYear = gradYear;
        }
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateAge(double age)
    {
        Age = age;
    }

    public void UpdateEmail(string email)
    {
        Email = email;
    }

    public override string ToString()
    {
        return $"Student Information for {Name}\nAge: {Age}\nEMail: {Email}\nGraduation Year: {GradYear}\n";
    }
}