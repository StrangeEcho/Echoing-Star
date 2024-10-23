public class HighSchoolStudent : Student
{
    public int Grade { get; set; }
    public string ClassName { get; set; }
    public bool IsCollegePrep { get; set; }

    public HighSchoolStudent(string name, string school, int grade,
        string clsName, bool collPrep) : base(name, school)
    {
        Grade = grade;
        ClassName = clsName;
        IsCollegePrep = collPrep;
    }

    public override string ToString()
    {
        return
            $"{GetStudentInformation()}\nStudent Grade: {Grade:D}\nStudent Class: {ClassName}\nCollege Prep?: {IsCollegePrep}";
    }
}