public class TextFileDemo
{
    private const string FILE_NAME = "Ruben.txt";

    public static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 4 Text Files GP\n");
        Console.WriteLine(WriteToFile());
        Console.WriteLine(ReadFromFile());
    }

    private static string WriteToFile()
    {
        File.WriteAllText(FILE_NAME, "Hello Ruben Thomas!" + Environment.NewLine);

        File.AppendAllText(FILE_NAME, "You just wrote 2 lines of text to a file");
        return "Sucessfully wrote to the file";
    }

    private static string ReadFromFile()
    {
        string[] readText = File.ReadAllLines(FILE_NAME);

        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }

        return "All lines from file printed";
    }
}