using System.Data.SQLite;

public class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas, Week 4 Database Performance Assessment\n\n");

        SQLiteConnection conn = DBHelpers.CreateConnection("Ruben.DB");
        if (conn != null)
        {
            DBHelpers.CreateTable(conn, "DBScript.sql");
            
            // Add Addresses To Database
            AddressDB.AddAddress(conn, new Address("123 Street St", "", "Newport News", "Virginia", 23608));
            AddressDB.AddAddress(conn, new Address("456 Lane Rd", "Suite 001", "Williamsburg", "Virginia", 23185));
            AddressDB.AddAddress(conn, new Address("789 Circle Blvd", "Apt 3333", "Hampton", "Virginia", 00000));
            
            // Read Addresses from Database
            Console.WriteLine("Reading from Database:");
            PrintAddressList(AddressDB.GetAllAddresses(conn));
            
            // Update From Database
            Console.WriteLine("Updating a row in the Database");
            AddressDB.UpdateAddress(conn, new Address(1, "123 Street Rd", "", "Newport News", "Virginia", 23608));
            Console.WriteLine(AddressDB.GetAddress(conn, 1).ToString());
            
            // Delete From Database w/ Output
            Console.WriteLine("Deleting a row in the Database");
            AddressDB.DeleteAddress(conn, 1);
            PrintAddressList(AddressDB.GetAllAddresses(conn));
            
            // Getting an invalid address by invalid ID
            Console.WriteLine("Invalid ID");
            Console.WriteLine(AddressDB.GetAddress(conn, -5));
        }
        
    }

    private static void PrintAddressList(List<Address> addresses)
    {
        foreach (Address address in addresses)
        {
            Console.WriteLine(address.ToString());
        }
    }
}