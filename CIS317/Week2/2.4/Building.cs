public class Building {
    public string StreetAddress { get; set; }
    public int NumFloors { get; set; }
    public string ExteriorMaterial { get; set; }

    public Building(string address, int numfloors, string extmaterial) {
        StreetAddress = address;
        NumFloors = numfloors;
        ExteriorMaterial = extmaterial;
    }

    public override string ToString() {
        return $"There is a {NumFloors} story building at {StreetAddress} made of {ExteriorMaterial}";
    }
}