using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a sample scripture
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("Press Enter to reveal a word or type 'quit' to exit.");

        // Display the full scripture at the beginning
        Console.WriteLine(scripture.GetScriptureText());

        string input;

        do
        {
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Clear the console before displaying the next set of hidden words
            Console.Clear();

            if (scripture.HideNextWords(3)) //Hide three words at a time
            {
                Console.WriteLine("Welcome to the Scripture Memorization Program!");
                Console.WriteLine("Press Enter to reveal a word or type 'quit' to exit.");
                Console.WriteLine(scripture.GetScriptureText());
            }
            else
            {
                Console.WriteLine("All words are hidden!");
                break;
            }
        } while (true);
    }
}
