public class House : Building // Abstract class inheritance
{
    private int NumRooms;
    private Door FrontDoor;
    private Kitchen MainKitchen;

    public House(int numRooms, Door frontDoor, Kitchen mainKitchen) : // Constructor & base class Constructor
        base("House")
    {
        NumRooms = numRooms;
        FrontDoor = frontDoor;
        MainKitchen = mainKitchen;
    }

    public override int GetRooms() // Parameter for NumRooms is not public. Use method to Get parameter value
    {
        return NumRooms;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nRooms: {NumRooms}\nFrontDoor: {FrontDoor}\nMainKitchen: {MainKitchen}\n";
    }
}