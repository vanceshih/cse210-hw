// Derived class for Stationary Bicycle activity
class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    // Override method to get the distance for Cycling activity
    public override double GetDistance()
    {
        return speed * Minutes / 60.0;
    }

    // Override method to get the speed for Stationary Bicycle activity
    public override double GetSpeed()
    {
        return speed;
    }

    // Override method to get the pace for Stationary Bicycle activity
    public override double GetPace()
    {
        return (60.0 / speed);
    }
}
