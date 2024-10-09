public class Dog : IAnimal {
    private string m_name;
    public string FavoriteActivity { get; set; }

    public Dog(string name, string favoriteActivity) {
        m_name = name;
        FavoriteActivity = favoriteActivity;
    }

    public string GetName() {
        return m_name;
    }

    public string MakeSound() {
        return "Bow Wow Wow Woof Woof";
    }

    public void Move(string start, string end) {
        Console.WriteLine($"Bounding from {start} to {end}");
    }

    public override string ToString() {
        return $"Dog Information:\nName: {m_name}\nFavorite Activity: {FavoriteActivity}\n";
    }
}