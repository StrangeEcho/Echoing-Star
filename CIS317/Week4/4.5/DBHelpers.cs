using System.Data.SQLite;

public class DBHelpers
{
    public static SQLiteConnection CreateConnection(string dbName)
    {
        SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName}");
        conn.Open();
        return conn;
    }

    public static void CreateTable(SQLiteConnection conn, string path)
    {
        string sql = File.ReadAllText(path);
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);

        cmd.ExecuteNonQuery();
        Console.WriteLine($"Created Table from {path}\n");
    }
}