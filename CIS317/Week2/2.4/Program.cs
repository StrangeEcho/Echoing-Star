public class MainProgram {
    public static void Main(string[] args) {
        Console.WriteLine("Ruben Thomas - Week 2 Polymorphism Performance Assessment\n\n");

        List<Building> buildings = new List<Building>();

        buildings.Add(new Building("123 Street St", 3, "Brick"));
        buildings.Add(new Building("321 Antartica Rd", 1, "Ice"));

        Console.WriteLine("Buildings Array");
        foreach (Building building in buildings) {
            PrintBuilding(building);
        }

        Console.WriteLine();

        List<House> houses = new List<House>();

        houses.Add(new House("1 House Blvd", 2, "Brick", "Red", 3));
        houses.Add(new House("2 2nd House Rd", 1, "Metal", "White", 1));

        Console.WriteLine("Houses Array");
        foreach(House house in houses) {
            PrintBuilding(house);
        }

    }

    private static void PrintBuilding(Building building) {
        Console.WriteLine($">> {building.ToString()}");
    }

}