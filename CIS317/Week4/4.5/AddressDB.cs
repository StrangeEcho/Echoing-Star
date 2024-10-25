using System.Data.SQLite;
using System.Net.Sockets;

public class AddressDB
{
    public static void AddAddress(SQLiteConnection conn, Address address)
    {
        string sql = "INSERT INTO Addresses (Address1, Address2, City, State, ZipCode) "
            + "VALUES (@Address1, @Address2, @City, @State, @ZipCode)";

        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Address1", address.Address1);
        cmd.Parameters.AddWithValue("@Address2", address.Address2);
        cmd.Parameters.AddWithValue("@City", address.City);
        cmd.Parameters.AddWithValue("@State", address.State);
        cmd.Parameters.AddWithValue("@ZipCode", address.ZipCode);

        cmd.ExecuteNonQuery();

    }

    public static void UpdateAddress(SQLiteConnection conn, Address address)
    {
        string sql = "UPDATE Addresses SET Address1 = @Address1, Address2 = @Address2, City = @City, State = @State, " 
                     + "ZipCode = @ZipCode WHERE AddressID = @AddressID";
        
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Address1", address.Address1);
        cmd.Parameters.AddWithValue("@Address2", address.Address2);
        cmd.Parameters.AddWithValue("@City", address.City);
        cmd.Parameters.AddWithValue("@State", address.State);
        cmd.Parameters.AddWithValue("@ZipCode", address.ZipCode);
        cmd.Parameters.AddWithValue("@AddressID", address.AddressId);

        cmd.ExecuteNonQuery();
    }

    public static void DeleteAddress(SQLiteConnection conn, int id)
    {
        string sql = "DELETE FROM Addresses WHERE AddressID = @AddressID";

        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@AddressID", id);

        cmd.ExecuteNonQuery();
    }

    public static List<Address> GetAllAddresses(SQLiteConnection conn)
    {
        List<Address> addresses = new List<Address>();
        SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Addresses", conn);
        SQLiteDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            addresses.Add(
                new Address(
                    rdr.GetInt32(0),
                    rdr.GetString(1),
                    rdr.GetString(2),
                    rdr.GetString(3),
                    rdr.GetString(4),
                    rdr.GetInt32(5)
                )
            );
        }

        return addresses;
    }
    public static Address GetAddress(SQLiteConnection conn, int id) 
    {
        string sql = "SELECT * FROM Addresses WHERE AddressID = @AddressID";

        SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@AddressID", id);
        SQLiteDataReader rdr = cmd.ExecuteReader();

        if (rdr.Read())
        {
            return new Address(
                rdr.GetInt32(0),
                rdr.GetString(1),
                rdr.GetString(2),
                rdr.GetString(3),
                rdr.GetString(4),
                rdr.GetInt32(5)
            );
        }
        else
        {
            return new Address(-1, "", "", "", "", -1);
        }
    } 
}