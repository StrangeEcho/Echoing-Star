public class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - Week 3 Abstraction Performance Assessment\n\n");

        Console.WriteLine("Card Game Information");
        CardGame cardGame = new CardGame("Rummy", 5, 13);
        Console.WriteLine(cardGame.ToString() + "\n");

        Console.WriteLine("Board Game with Dice Game Information");
        DiceGame diceGame = new DiceGame("Monopoly", 6, 10);
        Console.WriteLine(diceGame.ToString() + "\n");

        Console.WriteLine("Board Game with Spinner Game Information");
        SpinnerGame spinnerGame = new SpinnerGame("Life", 4, 10);
        Console.WriteLine(spinnerGame.ToString());
    }
}