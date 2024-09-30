public class Student {
    public string Name { get; set; }
    public string SchoolName { get; set; }

    public Student(string name, string school) {
        Name = name;
        SchoolName = school;
    }

    public virtual string GetStudentInformation() {
        return $"Student Name: {Name}\nSchool Name: {SchoolName}";
    }

    public override string ToString()
    {
        return GetStudentInformation();
    }
}