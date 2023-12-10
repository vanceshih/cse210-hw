class Activity
{
    protected int _duration;
    protected int _countdown;

    public virtual void StartActivity(string name, string description, List<string> prompts, List<string> reflectionQuestions)
    {
        Console.WriteLine($"Welcome to the {name} activity");
        Console.WriteLine(description);

        SetDuration();
        PrepareToBegin();

        PerformActivity();

        DisplaySummary(name);
        PauseBeforeFinish();
        Console.WriteLine($"Activity completed in {_duration} seconds.");
        PauseBeforeFinish();
    }

    protected virtual void SetDuration()
    {
        Console.Write("How long in seconds, would you like for your session? ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for duration.");
            Console.Write("Enter duration of the activity in seconds: ");
        }
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine("Get ready...");
        PauseWithSpinner();
    }

    protected virtual void DisplaySummary(string activityName)
    {
        Console.WriteLine($"You have completed the {activityName} activity.");
    }

    protected virtual void PauseBeforeFinish()
    {
        Console.WriteLine("Pausing before finishing...");
        PauseWithSpinner();
    }

    protected virtual void PerformActivity()
    {
        // Placeholder for specific activity implementation in derived classes
    }

    protected void PauseWithSpinner()
    {
        List<string> animationString = new List<string> { "|", "/", "-", "\\" };
      
        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void PauseWithCountdown()
    {
        for (int i = _countdown; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(500); // Pause for 1000 milliseconds (1 second)
        }
        Console.WriteLine();
    }
}