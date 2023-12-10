class BreathingActivity : Activity
{
    private readonly string _breathingInMsg = "Breathe in...";
    private readonly string _breathingOutMsg = "Breathe out...";

    protected override void PerformActivity()
    {
        Console.WriteLine("Breathing activity started.");

        int breathInDuration = 4;  // Duration for breathing in (in seconds)
        int breathOutDuration = 6; // Duration for breathing out (in seconds)
        _countdown = _duration;     // Initialize the countdown

        while (_countdown >= breathInDuration)
        {
            Console.WriteLine($"{_breathingInMsg} (for {breathInDuration} seconds)");
            DisplayCountdownAnimation(breathInDuration);

            _countdown -= breathInDuration;

            if (_countdown <= 0)
            {
                break; // Break if no time left for breathing out
            }

            Console.WriteLine($"{_breathingOutMsg} (for {breathOutDuration} seconds)");
            DisplayCountdownAnimation(breathOutDuration);

            _countdown -= breathOutDuration;
        }

        Console.WriteLine("Breathing activity completed.");
    }

    private void DisplayCountdownAnimation(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write("O");
            Thread.Sleep(500); // Pause for 500 milliseconds (0.5 seconds)
            Console.Write("\b \b"); // Erase the + character
            Console.Write(".");
            Thread.Sleep(500); // Pause for 500 milliseconds (0.5 seconds)
            Console.Write("\b \b"); // Erase the - character
        }
        Console.WriteLine();
    }
}
