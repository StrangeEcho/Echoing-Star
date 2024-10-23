using System.Data.SQLite;
public class DBExample
{
    public static void Main(string[] args)
    {
        const string dbName = "Ruben.db";
        Console.WriteLine("\nRuben Thomas, Week 4 Database Interactions GP\n");
        SQLiteConnection conn = SQLiteDatabase.Connect(dbName);
        if (conn != null)
        {
            PersonDB.CreateTable(conn);
            //Create
            PersonDB.AddPerson(conn, new Person("Ruben", "Thomas", 21));
            PersonDB.AddPerson(conn, new Person("John", "Smith", 45));
            PersonDB.AddPerson(conn, new Person("Jane", "Jones", 24));
            PersonDB.AddPerson(conn, new Person("Joe", "Diffy", 61));
            //Read
            Console.WriteLine("\nAll People in the Database");
            PrintPeople(PersonDB.GetAllPeople(conn));
            Console.WriteLine("\nGet a Person Using an Invalid ID");
            PrintPerson(PersonDB.GetPerson(conn, -5));
            //Update
            Person personToUpdate = new Person(2, "James", "Smith", 37);
            PersonDB.UpdatePerson(conn, personToUpdate);
            Person updatedPerson = PersonDB.GetPerson(conn, personToUpdate.ID);
            Console.WriteLine("\nUpdated Person");
            PrintPerson(updatedPerson);
            //Delete
            PersonDB.DeletePerson(conn, personToUpdate.ID);
            Console.WriteLine("\nAll People in the Database");
            PrintPeople(PersonDB.GetAllPeople(conn));
        }
    }

    private static void PrintPeople(List<Person> people)
    {
        foreach (Person p in people)
        {
            PrintPerson(p);
        }
    }
    private static void PrintPerson(Person p)
    {
        Console.WriteLine("Person " + p.ID + ": ");
        Console.WriteLine(p.FirstName + " " + p.LastName + " is "
            + p.Age + " years old\n");
    }
}