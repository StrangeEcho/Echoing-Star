public class PrimarySchoolStudent: Student {
    public string Grade { get; set; }

    public PrimarySchoolStudent(string name, string school, string grade) : base (name, school) {
        Grade = grade; 
    }

    public override string GetStudentInformation() {
        return $"{base.GetStudentInformation()}\nStudent Grade: {Grade}";
    }

    public override string ToString() {
        return GetStudentInformation();
    }
}