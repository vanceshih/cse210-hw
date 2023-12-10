using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        Program program = new Program();
        program.DisplayMenu();
    }

    private void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                ExecuteActivity(choice);
                if (choice == 4)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private void ExecuteActivity(int choice)
    {
        switch (choice)
        {
            case 1:
                StartBreathingActivity();
                break;
            case 2:
                StartReflectionActivity();
                break;
            case 3:
                StartListingActivity();
                break;
            case 4:
                Console.WriteLine("Quitting program.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid menu option.");
                break;
        }
    }

    private void StartBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.StartActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", new List<string>(), new List<string>());
    }

    private void StartReflectionActivity()
    {
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.StartActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", new List<string>(), new List<string>());
    }

    private void StartListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", new List<string>(), new List<string>());
    }
}