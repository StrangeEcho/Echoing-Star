public class Address
{
    public int AddressId { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int ZipCode { get; set; }

    public Address(int addressId, string address1, string address2, string city, string state, int zipCode)
    {
        AddressId = addressId;
        Address1 = address1;
        Address2 = address2;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public Address(string address1, string address2, string city, string state, int zipCode)
    {
        Address1 = address1;
        Address2 = address2;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"\tAddress ID: {AddressId}\n\tAddress Line 1: {Address1}\n\tAddress Line 2: {Address2}\n\t"
               + $"City: {City}\n\tState: {State}\n\tZip Code: {ZipCode}\n";
    }
}