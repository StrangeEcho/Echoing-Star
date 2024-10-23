public class Person
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(int id, string firstName, string lastName, int age)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}