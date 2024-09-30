public class GraduateStudent : CollegeStudent  {
    public bool ThesisRequired { get; set; }

    public GraduateStudent(string name, string school, string major, bool thesis) 
        : base(name, school, major) {
        ThesisRequired = thesis;
    } 

    public override string GetStudentInformation() {
        return $"{base.GetStudentInformation()}\nThesis Required: {ThesisRequired}";
    }

    public override string ToString() {
        return $"{base.GetStudentInformation()}\n{ThesisRequired}";
    }
}