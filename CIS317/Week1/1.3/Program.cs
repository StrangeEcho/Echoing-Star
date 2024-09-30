public class InheritanceTest {
    static void Main(string[] args) {
        //Replace "Your Name" with your first and last name
        Console.WriteLine("\nRuben Thomas - CIS214 GP - Inheritance");
        Console.WriteLine("--------------------------------------");
        
        //Create a student object & print the contents to the console
        Student s = new Student("John Smith", "Any School");
        Console.WriteLine("***** Student class using ToString *****");
        Console.WriteLine(s); //uses the ToString method implicitly
        Console.WriteLine(
        "***** Student class using GetStudentInformation *****");
        Console.WriteLine(s.GetStudentInformation());
        
        //Create a primary school student object & print the contents to the
        //console
        PrimarySchoolStudent pss = new PrimarySchoolStudent("Jane Doe",
        "Some Elementary School", "Pre-K");
        Console.WriteLine(
        "\n***** PrimarySchoolStudent class using ToString *****");
        Console.WriteLine(pss); //uses the ToString method implicitly
        Console.WriteLine(
        "*** PrimarySchoolStudent class using GetStudentInformation ***");
        Console.WriteLine(pss.GetStudentInformation());
        
        //Create a High school student object & print the contents to the
        //console
        HighSchoolStudent hss = new HighSchoolStudent("Fred Smythe",
        "Some High School", 10, "Sohpmore", true);
        Console.WriteLine(
        "\n***** HighSchoolStudent class using ToString *****");
        Console.WriteLine(hss); //uses the ToString method implicitly
        Console.WriteLine(
        "***** HighSchoolStudent class using GetStudentInformation *****");
        //Note that the following only prints the student name and school name
        //because we didn't override the method with our own implementation, so
        //we're getting the base class functionality...but we can still call it
        Console.WriteLine(hss.GetStudentInformation());
        
        //Create a college student object & print the contents to the console
        CollegeStudent cs = new CollegeStudent("Your Name", "ECPI University",
        "Computer Science");
        Console.WriteLine("\n***** CollegeStudent class using ToString *****");
        Console.WriteLine(cs); //uses the ToString method implicitly
        Console.WriteLine(
        "***** CollegeStudent class using GetStudentInformation *****");
        Console.WriteLine(cs.GetStudentInformation());
        
        //Create an undergraduate student object & print the contents to the
        //console
        UnderGraduateStudent us = new UnderGraduateStudent("Your Name",
        "ECPI University", "Computer Science", "Junior");
        Console.WriteLine(
        "\n***** UndergraduateStudent class using ToString *****");
        Console.WriteLine(us); //uses the ToString method implicitly
        Console.WriteLine(
        "*** UndergraduateStudent class using GetStudentInformation ***");
        Console.WriteLine(us.GetStudentInformation());
        
        //Create a Graduate student object & print the contents to the console
        GraduateStudent gs = new GraduateStudent("Dean Jones", "Tulane",
        "Psychology", true);
        Console.WriteLine(
        "\n***** GraduateStudent class using ToString *****");
        Console.WriteLine(gs); //uses the ToString method implicitly
        Console.WriteLine(
        "***** GraduateStudent class using GetStudentInformation *****");
        Console.WriteLine(gs.GetStudentInformation());
        Console.WriteLine(); //just add a blank line
    }
}