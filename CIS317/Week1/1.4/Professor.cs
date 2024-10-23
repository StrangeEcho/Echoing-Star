public class Professor
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Department { get; set; }

    public Professor(string name, string title, string dept)
    {
        Name = name;
        Title = title;
        Department = dept;
    }
}