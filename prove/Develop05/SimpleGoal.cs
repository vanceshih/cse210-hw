class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, string description, bool completed = false) : base(name, points, description)
    {
        _completed = completed;
    }
}