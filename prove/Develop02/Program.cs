using System;
using System.Collections.Generic;

class Program
{
    // List of writing prompts
    public static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do overday, what would it be?"
    };

    // List of motivational messages
    public static List<string> motivationalMessages = new List<string>
    {
        "Every entry is a step toward self-discovery. Keep going!",
        "You're creating a meaningful record of your life. Well done!",
        "Writing in your journal is a beautiful habit. Keep nurturing it!",
        "Each entry captures a moment in time. Keep preserving memories!",
        "Your journal is a treasure chest of experiences. Keep it up!",
        "Reflection is a powerful tool. You're using it wisely!",
        "Your journal is a testament to your journey. Keep writing!",
        "You're building a wonderful habit of self-reflection. Keep the momentum!",
        "Your thoughts are valuable, and your journal reflects that. Keep it going!",
        "Every day you write, you're one step closer to understanding yourself."
    };

    static void Main()
    {
        Journal journal = new Journal();
        string choice;
        int consecutiveDays = 0; // Initialize consecutive days counter

        do
        {
            Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Randomly select a prompt
                    Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Count)];

                    // Display random selected prompt
                    Console.WriteLine(prompt);

                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();

                    journal.AddEntry(prompt, response);

                    // Increment consecutive days and display motivational message
                    consecutiveDays++;
                    DisplayMotivationalMessage(consecutiveDays);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Please enter the filename to save: ");
                    string saveFileName = (Console.ReadLine());
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    Console.Write("Please enter the filename to load: ");
                    string loadFileName = (Console.ReadLine());
                    journal.LoadFromFile(loadFileName);
                    break; 
               
               case "5":
                    Console.WriteLine("Exiting the program.");
                    break;
            }

        } while (choice != "5");            
        }
    public static void DisplayMotivationalMessage(int consecutiveOccasions)
    {
        if (consecutiveOccasions <= motivationalMessages.Count)
        {
            Console.WriteLine($"Awesome! You've maintained your journal for {consecutiveOccasions} consecutive occasions.");
            Console.WriteLine(motivationalMessages[consecutiveOccasions - 1]);
        }
        else
        {
            Console.WriteLine("Keep up the great work!");
        }
    }        
}