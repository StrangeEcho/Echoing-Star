public class Corn : Vegetable {
    public string Variety { get; set; }
    public string Packaging { get; set; }

    public Corn(string servingSize, string plantingSeason, string harvestSeason, string variety, string packaging)
        : base(variety + " Corn", servingSize, plantingSeason, harvestSeason) {
            Variety = variety;
            Packaging = packaging;
        }
    
    public override string ToString() {
        return $"{base.ToString()}Type of corn: {Variety}\nPackage Description: {Packaging}";
    }
}