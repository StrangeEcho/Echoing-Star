using System.Security.Cryptography.X509Certificates;

public class Student
{
    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;
    }

    public override string ToString()
    {
        return $"Student: {Name}\nMajor: {Major}\nGPA: {GPA}";
    }

    public override bool Equals(object? obj)
    {
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            Student s = (Student)obj;
            return Name == s.Name;
        }
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}