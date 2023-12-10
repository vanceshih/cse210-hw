// Derived class for Swimming activity
class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    // Override method to get the distance for Swimming activity
    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Convert meters to kilometers
    }

    // Override method to get the speed for Swimming activity
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return distance == 0 ? 0 : distance / (base.Minutes / 60.0);
    }

    // Override method to get the pace for Swimming activity
    public override double GetPace()
    {
        double distance = GetDistance();
        return distance == 0 ? 0 : base.Minutes / distance;
    }
}

