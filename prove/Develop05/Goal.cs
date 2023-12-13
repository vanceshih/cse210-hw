class Goal
{
    protected string _name;
    protected int _points;
    protected bool _completed;
    protected string _description;

    protected static int totalPoints = 0;

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _completed = false;
        _description = description;
    }

    public string Name => _name;
    public int Value => _points;
    public bool IsCompleted() => _completed;
    public string Description => _description;

    public static int TotalPoints => totalPoints;

    public virtual void RecordCompletion()
    {
        _completed = true;
    }

    protected void MarkComplete()
    {
        _completed = true;
    }

    public virtual void DisplayProgress()
    {
        string completionStatus = _completed ? "[X]" : "[]";
        Console.WriteLine($"{completionStatus} {Name} ({Description}) - {GetProgress()}");
    }

    public virtual string GetProgress()
    {
        return _completed ? "Completed" : "Not Completed";
    }
}
