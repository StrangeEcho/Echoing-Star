public class Tire { 
    public string Manafacturer { get; set; }
    public string Size { get; set; }
    public int MaxPressure { get; set; }
    public int MinPressure { get; set; }
    public string TireType { get; set; }

    public Tire(string manafacturer, string size, int minpressure, int maxpressure, string tiretype) {
        Manafacturer = manafacturer;
        Size = size;
        MinPressure = minpressure;
        MaxPressure = maxpressure;
        TireType = tiretype;
    }

    public override string ToString() {
        return $"Manafacturer: {Manafacturer}\nSize: {Size}\nMin Pressure: {MinPressure}\nMax Pressure: {MaxPressure}\nType: {TireType}";
    }
}