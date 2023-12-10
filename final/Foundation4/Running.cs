// Derived class for Running activity
class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    // Override method to get the distance for Running activity
    public override double GetDistance()
    {
        return distance;
    }

    // Override method to get the speed for Running activity
    public override double GetSpeed()
    {
        return distance / (base.Minutes / 60.0);
    }

    // Override method to get the pace for Running activity
    public override double GetPace()
    {
        return (base.Minutes / distance);
    }
}
