/*****
* name: Ruben Thomas
* date: 6.7.2024
* assignment: CIS214 Week 5 PA - Inheritance & Overriding
*
*/

public class Animal { 
    public string Name { get; set; }
    public int Legs { get; set; }

    public Animal(String name, int legs) {
        Name = name;
        Legs = legs;
    }

    public string GetName() {
        return Name;
    }

    public void SetName(String name) {
        Name = name;
    }

    public int GetLegs() {
        return Legs;
    }

    public void SetLegs(int legs) {
        Legs = legs;
    }

    public virtual void PrintAnimal() {
        Console.WriteLine("The Animal's name is {0} and it has {1} legs", Name, Legs);
    }
}

public class Cat : Animal {
    public string Sound { get; set; }

    public Cat(String name, int legs, String sound) : base(name, legs) {
        Sound = sound;
    }

    public string GetSound() {
        return Sound;
    }

    public void SetSound(String sound) {
        Sound = sound;
    }

    public override void PrintAnimal() {
        Console.WriteLine("The cat's name is {0} and it has {1} legs and makes a {2} sound", Name, Legs, Sound);
    }
}

public class App {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 5 PA - Inheritance & Overriding\n");

        Animal a = new Animal("Roo", 2);
        Cat c = new Cat("Fluffy", 4, "meow");

        a.PrintAnimal();
        c.PrintAnimal();

        a.SetName("Flipper");
        a.SetLegs(0);

        c.SetName("Garfield");
        c.SetSound("Im HUNGRY");

        a.PrintAnimal();
        c.PrintAnimal();
    }
}