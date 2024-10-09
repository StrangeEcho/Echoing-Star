public class Condominium : Building {
    public int NumUnits { get; set; }

    public Condominium(string address, int numfloors, string extmaterial, int numunits) 
        : base(address, numfloors, extmaterial) {
            NumUnits = numunits;
        }
    
    public override string ToString() {
        return $"{base.ToString()}\nIt is a condominium that contains {NumUnits} units";
    }
}