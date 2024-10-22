using System.Linq.Expressions;
using System.Reflection.Metadata;

public class BinaryFileDemo {
    private const string FILE_NAME = "Ruben.dat";

    public static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas, Week 4 Text Files GP\n");
        Console.WriteLine(WriteToFile());
        Console.WriteLine(ReadFromFile());
    }

    public static string WriteToFile() {
        try {
            using (BinaryWriter writer = new BinaryWriter(File.Open(FILE_NAME, FileMode.Create))) {
                Console.WriteLine("Starting to write to file");
                writer.Write("String written in binary");
                writer.Write(5);
                writer.Write(9.95);
                writer.Write(true);
                Console.WriteLine("Finished writing to file\n");

                return "Write completed successfully";
            }
        }
        catch (IOException e) {
            return $"An error occured: {e.Message}";
        }
    }

    public static string ReadFromFile() {
        try {
            using (BinaryReader reader = new BinaryReader(File.Open(FILE_NAME, FileMode.Open))) {
                Console.WriteLine("Starting to read from file");

                Console.WriteLine($"String value from file: {reader.ReadString()}");
                Console.WriteLine($"Integer value from file: {reader.ReadInt32()}");
                Console.WriteLine($"Double value from file: {reader.ReadDouble()}");
                Console.WriteLine($"Boolean value from file: {reader.ReadBoolean()}");
                
                return "Reading completed succesfully";
            }
        }
        catch (IOException e) {
            return $"An error occured: {e.Message}";
        }
    }
}