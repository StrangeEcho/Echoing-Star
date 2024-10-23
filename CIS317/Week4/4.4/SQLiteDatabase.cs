using System.Data.SQLite;

public class SQLiteDatabase
{
    public static SQLiteConnection Connect(string database)
    {
        string connectionString = $"Data Source={database}";
        SQLiteConnection conn = new SQLiteConnection(connectionString);

        try
        {
            conn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return conn;
    }
}