public class Person {
    public string Name {get; protected set; }
    public double Age {get; protected set; }
    public string Email { get; protected set; }

    protected Person(string name, double age, string email) {
        Name = name;
        Age = age;
        Email = email;
    }
}