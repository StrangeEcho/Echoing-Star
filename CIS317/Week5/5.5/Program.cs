using System.Runtime.InteropServices.JavaScript;

public class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - Week 5 Practical Exam\n");

        var logFile = "ruben-log.txt";
        using (StreamWriter log = new StreamWriter(logFile))
        {
            log.WriteLine($"Starting application at {DateTime.Now}.");
            log.WriteLine($"Creating list of buildings at {DateTime.Now}.");
            
            List<Building> buildings = new List<Building>
            {
                new House(3, new Door(36, "Red"), new Kitchen("Modern", "GE")),
                new House(4, new Door(32, "Blue"), new Kitchen("Country", "Whirlpool")),
                new House(5, new Door(34, "Green"), new Kitchen("Contemporary", "Samsung")),
                new House(6, new Door(30, "Brown"), new Kitchen("Chef's", "LG")),
                new House(2, new Door(28, "White"), new Kitchen("Modern", "Bosch"))
            };
            log.WriteLine($"Finished appending 5 House objects to the list at {DateTime.Now}");

            // Print the list of buildings iteratively
            Console.WriteLine("\nIterative Building List:");
            PrintBuildingsIteratively(buildings);
            log.WriteLine($"Printed buildings iteratively at {DateTime.Now}.");

            // Print the list of buildings recursively
            Console.WriteLine("\nRecursive Building List");
            PrintBuildingsRecursively(buildings, 0);
            log.WriteLine($"Printed buildings recursively at {DateTime.Now}");

            log.WriteLine($"Application completed successfully at {DateTime.Now}.");
        }

        // Display contents of the log file
        Console.WriteLine("\nLog File Contents:");
        Console.WriteLine(File.ReadAllText(logFile));
    }

    private static void PrintBuildingsIteratively(List<Building> buildings)
    {
        foreach (var building in buildings)
        {
            Console.WriteLine(building);
        }
    }
    
    private static void PrintBuildingsRecursively(List<Building> buildings, int index)
    {
        if (index < buildings.Count)
        {
            Console.WriteLine(buildings[index]);
            PrintBuildingsRecursively(buildings, index + 1);
        }
    }
}