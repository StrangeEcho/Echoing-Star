public abstract class Game {
    public string Name { get; set; }
    public int NumPlayers { get; set; }

    public abstract string StartGame();
    public abstract string StartTurn();
    public abstract string EndTurn();

    public Game(string name, int numplayers) {
        Name = name;
        NumPlayers = numplayers;
    }

    public override string ToString()
    {
        return $"Welcome to {Name}. We have {NumPlayers} with us today\n\tTo start the game: {StartGame()}\n\tTo start a turn: {StartTurn()}\n\tA Turn ends when {EndTurn()}";
    }

}