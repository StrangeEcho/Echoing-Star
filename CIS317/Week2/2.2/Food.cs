public class Food {
    public string Name { get; set; }
    public string ServingSize { get; set; }

    public Food(string name, string servingSize) {
        Name = name;
        ServingSize = servingSize;
    }

    public override string ToString() {
        return $"Class Name (Object Type) {this.GetType()}\nFood Name: {Name}\nServing Size: {ServingSize}\n";
    }
}