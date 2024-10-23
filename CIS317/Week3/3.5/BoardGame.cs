public abstract class BoardGame : Game
{
    public int MaxMove { get; set; }

    public BoardGame(string name, int numplayers, int maxmove) :
        base(name, numplayers)
    {
        MaxMove = maxmove;
    }

    public abstract override string StartGame();
    public abstract override string StartTurn();

    public override string EndTurn()
    {
        return "the player moves their piece the appropriate number of spaces";
    }
}