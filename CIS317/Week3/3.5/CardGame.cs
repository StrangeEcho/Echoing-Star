public class CardGame : Game
{
    public int NumCards { get; set; }

    public CardGame(string name, int numplayers, int numcards) :
        base(name, numplayers)
    {
        NumCards = numcards;
    }

    public override string StartGame()
    {
        return $"The dealer deals each person {NumCards} cards";
    }

    public override string StartTurn()
    {
        return "the player to the dealer's left draws or plays a card";
    }

    public override string EndTurn()
    {
        return "the player discards";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}