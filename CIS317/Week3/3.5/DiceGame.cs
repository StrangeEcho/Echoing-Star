public class DiceGame : BoardGame {
    public DiceGame(string name, int numplayers, int maxmove) :
        base(name, numplayers, maxmove) { }

    public override string StartGame()
    {
        return "all players roll one die; player with the highest roll goes first";
    }

    public override string StartTurn()
    {
        return "the players rolls the dice to determine the number of spaces to move";
    }
}