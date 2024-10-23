using System.Data.SQLite;

public class PersonDB
{
    public static void CreateTable(SQLiteConnection conn)
    {
        string sql = "CREATE TABLE IF NOT EXISTS People (\n"
                     + " ID integer PRIMARY KEY\n"
                     + " ,FirstName varchar(20)\n"
                     + " ,LastName varchar(40)\n"
                     + " ,Age integer);";

        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public static void AddPerson(SQLiteConnection conn, Person p)
    {
        string sql = "INSERT INTO People (FirstName, LastName, Age) "
                     + $"VALUES ({p.FirstName}, {p.LastName}, {p.Age})";
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public static void UpdatePerson(SQLiteConnection conn, Person p)
    {
        string sql = $"UPDATE peopleSET FirstName={p.FirstName}, LastName = {p.LastName}, "
                     + $"Age = {p.Age} WHERE ID = {p.ID}";
        
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        
    }

    public static void DeletePerson(SQLiteConnection conn, int id)
    {
        string sql = $"DELETE FROM People WHERE ID = {id}";
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public static List<Person> GetAllPeople(SQLiteConnection conn)
    {
        List<Person> people = new List<Person>();
        string sql = "SELECT * FROM People";
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);

        SQLiteDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            //
        }
    }
}