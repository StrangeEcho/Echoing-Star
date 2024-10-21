public class AccessSpecifiers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 3 Access Specifiers GP\n");

        Person person = new Student("John Smith", 22, "js@mail.com", 2022);

        Console.WriteLine("Person printed using Student's ToString");
        Console.WriteLine(person);

        Console.WriteLine("Person printed using Person property accessors");
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
        Console.WriteLine("EMail: " + person.Email);

        Student student = new Student("Jane Jones", 19, "jj@mail.com", 2023);

        Console.WriteLine("\nStudent printed using Student's ToString");
        Console.WriteLine(student);

        student.UpdateName("Jane Smith-Jones");
        student.UpdateAge(21.1);
        student.UpdateEmail("jsj@mail.com");
        student.UpdateGradYear(2023);

        Console.WriteLine("Student printed using Student & Person accessors");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("EMail: " + student.Email);
        Console.WriteLine("Graduation Year: " + student.GradYear);
    }
}