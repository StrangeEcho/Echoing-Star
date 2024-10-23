public class PolymorphismExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nRuben Thomas, Week 2 Polymorphism GP\n");

        Food food = new Food("Food Class", "Undefined");
        Vegetable veg = new Vegetable("Romaine Lettuce", "3 cups",
            "Spring", "Summer");
        Corn corn = new Corn("One Ear", "Spring", "Summer/Fall",
            "Sliver Queen Sweet", "4 ears per tray");
        Meat meat = new Meat("Angus Beef", "6 oz",
            "Free Range Grass Fed");

        List<Food> foods = new List<Food>();
        foods.Add(food);
        foods.Add(veg);
        foods.Add(corn);
        foods.Add(meat);

        Console.WriteLine("Items in foods List:\n");
        foreach (Food f in foods)
        {
            PrintFoodInfo(f);
        }

        List<Vegetable> veggies = new List<Vegetable>();
        veggies.Add(veg);
        veggies.Add(corn);

        Console.WriteLine("Items in veggies List:\n");
        foreach (Vegetable v in veggies)
        {
            PrintFoodInfo(v);
        }
    }

    private static void PrintFoodInfo(Food food)
    {
        Console.WriteLine(food.ToString());
    }
}