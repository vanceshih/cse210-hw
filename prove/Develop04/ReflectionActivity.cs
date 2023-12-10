class ReflectionActivity : Activity
{
    private readonly List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override void PerformActivity()
    {
        Console.WriteLine("Reflection activity started.");

        // Select a random prompt
        string randomPrompt = SelectRandomPrompt();
        Console.WriteLine(randomPrompt);

        // Prompt user to press Enter to continue
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        // Show additional messages
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");

        // Show countdown animation
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1000 milliseconds (1 second)
            Console.Write("\b \b");
        }
        Console.WriteLine();

        // Set the total duration
        _countdown = _duration;

        // Ask random questions related to the prompt
        AskRandomQuestions();

        Console.WriteLine("Reflection activity completed.");
    }

    private void AskRandomQuestions()
    {
        Random random = new Random();
        int remainingTime = _countdown;

        // Shuffle the reflection questions to ask them in a random order
        List<string> shuffledQuestions = _reflectionQuestions.OrderBy(q => random.Next()).ToList();

        foreach (var question in shuffledQuestions)
        {
            Console.WriteLine($"Reflect on: {question}");

            // Record the start time for each question
            DateTime startTime = DateTime.Now;

            // Continue asking questions until the remaining time is exhausted
            while (remainingTime > 0)
            {
                // Check if user pressed Enter to move to the next question
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }

                // Pause for a short duration
                Thread.Sleep(100);

                // Calculate the elapsed time
                DateTime currentTime = DateTime.Now;
                int elapsedSeconds = (int)Math.Round((currentTime - startTime).TotalSeconds);

                // Check if the question has been displayed for the required duration
                if (elapsedSeconds >= 5)  // Adjust the duration as needed
                {
                    break;
                }
            }

            // Adjust remaining time based on the time spent on the question
            remainingTime -= 5;  // Adjust the duration as needed

            // Check if there is still time remaining
            if (remainingTime <= 0)
            {
                break;
            }
        }
    }

    private string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_reflectionPrompts.Count);
        return _reflectionPrompts[index];
    }
}
