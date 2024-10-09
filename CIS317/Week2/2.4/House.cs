public class House : Building{
    public string Color { get; set; }
    public int NumRooms { get; set; }

    public House(string address, int numfloors, string extmaterial, string color, int numrooms) :
        base(address, numfloors, extmaterial) {
            Color = color;
            NumRooms = numrooms;
        }
    
    public override string ToString() {
        return $"{base.ToString()}\nIt is a house that contains {NumRooms} rooms";
    }
}