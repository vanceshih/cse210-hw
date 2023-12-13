class EternalGoal : Goal
{
    public EternalGoal(string name, int pointsPerCompletion, string description, bool completed = false) : base(name, pointsPerCompletion, description)
    {
        _completed = completed;
    }

    public override void RecordCompletion()
    {
        totalPoints += Value; // Add points each time the eternal goal is recorded
        MarkComplete();
    }

    public override void DisplayProgress()
    {
        string completionStatus = IsCompleted() ? "[X]" : "[]";
        Console.WriteLine($"{completionStatus} {Name} ({Description}) - {GetProgress()}");
    }

    public override string GetProgress()
    {
        return "Eternal goal - Never truly completed";
    }
}
