public class SpinnerGame : BoardGame
{
    public SpinnerGame(string name, int numplayers, int maxmove) :
        base(name, numplayers, maxmove)
    {
    }

    public override string StartGame()
    {
        return "all players spin the spinner. Player consest to 10 goes first";
    }

    public override string StartTurn()
    {
        return "the player spins the spinner to determine the number of spaces to move";
    }
}