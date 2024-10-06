public class Vegetable : Food {
    public string PlantingSeason { get; set; }
    public string HarvestSeason { get; set; }

    public Vegetable(string name, string servingSize, string plantingSeason, string harvestSeason) :
        base(name, servingSize) {
            PlantingSeason = plantingSeason;
            HarvestSeason = harvestSeason;
        }
    
    public override string ToString() {
        return $"{base.ToString()}Planting Time: {PlantingSeason}\nHarvest Time: {HarvestSeason}\n";
    }
} 