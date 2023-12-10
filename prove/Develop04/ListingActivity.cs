class ListingActivity : Activity
{
    private readonly List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private readonly List<string> _items = new List<string>();

    protected override void PerformActivity()
    {
        Console.WriteLine("Listing activity started.");

        // Display activity description
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // Select a random prompt
        string randomPrompt = SelectRandomPrompt();
        Console.WriteLine(randomPrompt);

        // Give a countdown to begin thinking about the prompt
        base.PauseBeforeFinish();

        // Set the total duration
        _countdown = _duration;

        // User lists items until they reach the specified duration
        while (_countdown > 0)
        {
            Console.Write("List items (separated by commas): ");
            var inputItems = Console.ReadLine()?.Split(',');

            if (inputItems != null)
            {
                _items.AddRange(inputItems);
                Console.WriteLine($"You listed {inputItems.Length} items.");
            }

            // Update the countdown based on the time spent listing items
            _countdown -= inputItems.Length > 0 ? 5 * inputItems.Length : 0;

            // Prompt user to keep listing items if there is still time
            if (_countdown > 0)
            {
                Console.WriteLine($"You have {_countdown} seconds remaining. Keep listing items!");
            }
        }

        // Display the number of items entered
        Console.WriteLine($"You entered a total of {_items.Count} items.");

        // Activity concludes with the standard finishing message
        base.PerformActivity();

        Console.WriteLine("Listing activity completed.");
    }

    private string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_listingPrompts.Count);
        return _listingPrompts[index];
    }
}
