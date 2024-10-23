using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class CollegeClass
{
    public string ClassID { get; set; }
    public string Subject { get; set; }
    public Professor Instructor { get; set; }
    public List<Student> Roster { get; }

    public CollegeClass(string id, string subj, Professor instructor)
    {
        ClassID = id;
        Subject = subj;
        Instructor = instructor;
        Roster = new List<Student>();
    }

    public void AddStudent(Student val)
    {
        Roster.Add(val);
    }

    public void AddStudent(string name, string major, double gpa)
    {
        Roster.Add(new Student(name, major, gpa));
    }

    public void RemoveStudent(string name)
    {
        Roster.Remove(new Student(name, "", 0.0));
    }

    private string FormatInstructor()
    {
        return $"Instructor: {Instructor.Title} {Instructor.Name} from {Instructor.Department}\n";
    }

    public string GetInfo()
    {
        string ret;
        ret = $"class ID: {ClassID}\nSubject: {Subject}\n-------------------------\n{FormatInstructor()}";
        ret += "\nCourse Roster:\n";
        foreach (Student student in Roster)
        {
            ret += student + "\n";
        }

        return ret;
    }
}