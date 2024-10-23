public class UnderGraduateStudent : CollegeStudent
{
    public string Year { get; set; }

    public UnderGraduateStudent(string name, string school, string major, string year) :
        base(name, school, major)
    {
        Year = year;
    }

    public override string GetStudentInformation()
    {
        return $"Student Name: {Name}\n College name: {SchoolName}\nStudent Year: {Year}\nStudent Major: {Major}";
    }

    public override string ToString()
    {
        return GetStudentInformation();
    }
}