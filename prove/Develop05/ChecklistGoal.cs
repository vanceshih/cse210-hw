class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completionCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int pointsPerCompletion, int targetCount, int bonusPoints, string description, bool completed = false, int completionCount = 0) : base(name, pointsPerCompletion, description)
    {
        _targetCount = targetCount;
        _completionCount = completed ? _targetCount : completionCount;
        _bonusPoints = bonusPoints;
    }

    public int TargetCount => _targetCount;
    public int CompletionCount => _completionCount;
    public int BonusPoints => _bonusPoints;

    public override void RecordCompletion()
    {
        if (_completionCount < _targetCount)
        {
            _completionCount++;
            totalPoints += Value; // Add points for each completion

            if (_completionCount == _targetCount)
            {
                totalPoints += _bonusPoints; // Add bonus points upon completing the checklist goal
                MarkComplete();
            }
        }
        else
        {
            Console.WriteLine("Checklist goal already completed.");
        }
    }

    public override void DisplayProgress()
    {
        string completionStatus = _completed ? "[X]" : "[]";
        Console.WriteLine($"{completionStatus} {Name} ({Description}) - {GetProgress()} (Bonus: {_bonusPoints} points)");
    }

    public override string GetProgress()
    {
        return $"Completed {_completionCount}/{_targetCount} times";
    }
}
