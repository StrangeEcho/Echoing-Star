public abstract class Building // abstract class indicating methods to be overwritten
{
    private string BuildingType; // private access specifier. not accessible outside the class

    protected Building(string buildingType) // protected access specifier for class construction
    {
        BuildingType = buildingType;
    }

    public abstract int GetRooms(); // abstract method to be overwritten

    public override string ToString() // Overwrite ToString() to return str that displays buildig type
    {
        return $"Building Type: {BuildingType}";
    }
}