public class Meat : Food
{
    public string Source { get; set; }

    public Meat(string name, string servingSize, string source) : base(name, servingSize)
    {
        Source = source;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nSource Description: {Source}\n";
    }
}