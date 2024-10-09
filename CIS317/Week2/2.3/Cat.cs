public class Cat : IAnimal {
    private string m_name;

    public Cat(string name) {
        m_name = name;
    }

    public string GetName() {
        return m_name;
    }

    public string MakeSound() {
        return "Meow Meow Meow Meow";
    }

    public void Move(string start, string end) {
        Console.WriteLine($"Leaping from {start} to {end}");
    }

    public override string ToString() {
        return $"Cat Information:\nName: {m_name}\n";
    }
}