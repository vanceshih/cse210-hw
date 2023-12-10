//Base class for all activities
class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    // Public property to get the minutes
    public int Minutes
    {
        get { return minutes; }
    }

    // Virtual method to get the distance
    public virtual double GetDistance()
    {
        return 0; // Base class implementation (override in derived classes)
    }

    // Virtual method to get the speed
    public virtual double GetSpeed()
    {
        return 0; // Base class implementation (override in derived classes)
    }

    // Virtual method to get the pace
    public virtual double GetPace()
    {
        return 0; // Base class implementation (override in derived classes)
    }

    // Method to get the summary
    public string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({minutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
