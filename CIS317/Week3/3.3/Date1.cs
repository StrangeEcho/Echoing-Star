using System.ComponentModel.DataAnnotations;

public class Date1
{
    public int Day { get; private set; }
    public string DayName { get; private set; }
    public int Month { get; private set; }
    public string Datestring { get; private set; }

    private readonly List<string> ValidDays = new List<string>
    {
        "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday"
    };

    public Date1(int day, string dayName, int month)
    {
        if (day < 1 || day > 31)
        {
            Datestring = "Invalid Day specified - Must be in range 1-31\n";
            DayName = string.Empty;
        }
        else if (!ValidDays.Contains(dayName.ToLower()))
        {
            Datestring = "Invalid Day Name Specified\n";
            DayName = string.Empty;
        }
        else if (month < 1 || month > 12)
        {
            Datestring = "Invalid Month specified - must be in range 1-12\n";
            DayName = string.Empty;
        }
        else
        {
            Day = day;
            DayName = dayName;
            Month = month;

            Datestring = GenerateDateString();
        }
    }

    public Date1() : this(1, "Sunday", 1)
    {
    }

    public Date1(int day, string DayName) : this(day, DayName, 1)
    {
    }

    public Date1(int month) : this(1, "Sunday", month)
    {
    }

    private string GenerateDateString()
    {
        return $"Date string created: Day: {Day}\nDay Name: {DayName}\nMonth: {Month}\n";
    }

    public override string ToString()
    {
        return Datestring;
    }
}