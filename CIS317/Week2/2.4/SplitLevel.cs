public class SplitLevel : House {
    public bool EntryLevelLivingSpace { get; set; }
    public SplitLevel(string address, string extmaterial, string color, int numrooms, bool entrylivingspace) 
        : base (address, 2, extmaterial, color, numrooms) {
            EntryLevelLivingSpace = entrylivingspace;
        }
    
    public override string ToString() {
        return $"{base.ToString()}\nIt is a Split-Level that {(EntryLevelLivingSpace ? "has" : "doesnt have")} entry level living space";
    }
}