using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int mNumber = int.Parse(magicNumber);
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 100);
        Console.WriteLine("Please guess the magic number (1-100).");

        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int gNumber = int.Parse(guessNumber);

        while (gNumber != mNumber)
        {
            if (gNumber < mNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guessNumber = Console.ReadLine();
            gNumber = int.Parse(guessNumber);
        }

        Console.WriteLine("You guessed it!");
    }
}