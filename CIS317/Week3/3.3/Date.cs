using System.Runtime.CompilerServices;

public class Date2 {
    private string Datestring = "No date specified";
    private DateTime StoredDate = new DateTime();

    public void SetDate2(string datestring) {
        if(DateTime.TryParse(datestring, out StoredDate)) {
            Datestring = datestring;
        }
        else {
            Datestring = $"Invalid date format. Value specified: {datestring}";
            StoredDate = new DateTime();
        }
    }

    public override string ToString()
    {
        return $"Date string Value: {Datestring}\nStored Date Value: {StoredDate}\n";
    }
}