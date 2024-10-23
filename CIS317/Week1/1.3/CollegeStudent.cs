public class CollegeStudent : Student
{
    public string Major { get; set; }

    public CollegeStudent(string name, string school, string major) :
        base(name, school)
    {
        Major = major;
    }

    public override string GetStudentInformation()
    {
        return $"{base.GetStudentInformation()}\nStudent Major: {Major}";
    }

    public override string ToString()
    {
        return $"{base.ToString}\nStudent Major: {Major}";
    }
}