using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static int totalPoints = 0;
    private static List<Goal> goals = new List<Goal>();

    static void Main()
    {
        int choice;
        do
        {
            DisplayMenu();
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                ProcessChoice(choice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 6);
    }

    static void DisplayMenu()
    {
        Console.WriteLine($"You have {totalPoints} points");
        Console.WriteLine("Menu Option:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                CreateNewGoal();
                break;
            case 2:
                ListGoals();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                Console.WriteLine("Quitting the program.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid menu option.");
                break;
        }
    }

    static void CreateNewGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description for the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the point value for the goal: ");
        if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
        {
            Console.WriteLine("Choose the type of goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            if (int.TryParse(Console.ReadLine(), out int goalType))
            {
                switch (goalType)
                {
                    case 1:
                        goals.Add(new SimpleGoal(name, value, description));
                        break;
                    case 2:
                        CreateEternalGoal(name, value, description);
                        break;
                    case 3:
                        CreateChecklistGoal(name, value, description);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type. Goal creation failed.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Goal creation failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for point value. Goal creation failed.");
        }
    }

    static void CreateEternalGoal(string name, int value, string description)
    {
        goals.Add(new EternalGoal(name, value, description));
    }

    static void CreateChecklistGoal(string name, int value, string description)
    {
        Console.Write("Enter the target count for the checklist goal: ");
        if (int.TryParse(Console.ReadLine(), out int targetCount) && targetCount > 0)
        {
            Console.Write("Enter the bonus points for completing the checklist goal: ");
            if (int.TryParse(Console.ReadLine(), out int bonusPoints))
            {
                goals.Add(new ChecklistGoal(name, value, targetCount, bonusPoints, description));
            }
            else
            {
                Console.WriteLine("Invalid input for bonus points. Checklist goal creation failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for target count. Checklist goal creation failed.");
        }
    }

    static void ListGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
    }

    static void SaveGoals()
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Save total points first
                writer.WriteLine($"TotalPoints,{totalPoints}");

                foreach (var goal in goals)
                {
                    if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine($"{nameof(SimpleGoal)},{simpleGoal.Name},{simpleGoal.Value},{simpleGoal.IsCompleted()},{simpleGoal.Description}");
                    }
                    else if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine($"{nameof(EternalGoal)},{eternalGoal.Name},{eternalGoal.Value},{eternalGoal.IsCompleted()},{eternalGoal.Description}");
                    }
                    else if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"{nameof(ChecklistGoal)},{goal.Name},{goal.Value},{goal.IsCompleted()},{checklistGoal.CompletionCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints},{checklistGoal.Description}");
                    }
                    else
                    {
                        writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.IsCompleted()},{goal.Description}");
                    }
                }
            }
            Console.WriteLine($"Goals saved successfully to {fileName}.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine();

        goals.Clear(); // Clear existing goals before loading
        try
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                // Read total points
                if (lines.Length > 0 && lines[0].StartsWith("TotalPoints,"))
                {
                    totalPoints = int.Parse(lines[0].Split(',')[1]);
                }

                // Process goals
                for (int i = 1; i < lines.Length; i++)
                {
                    ProcessGoalLine(lines[i]);
                }
                Console.WriteLine($"Goals loaded successfully from {fileName}.");
            }
            else
            {
                Console.WriteLine($"No saved goals found at {fileName}.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    static void ProcessGoalLine(string line)
    {
        string[] parts = line.Split(',');
        if (parts.Length >= 6)
        {
            string goalType = parts[0];
            string name = parts[1];
            int value = int.Parse(parts[2]);
            bool completed = bool.Parse(parts[3]);
            string description = parts[4];

            switch (goalType)
            {
                case nameof(SimpleGoal):
                    goals.Add(new SimpleGoal(name, value, description, completed));
                    break;
                case nameof(EternalGoal):
                    goals.Add(new EternalGoal(name, value, description, completed));
                    break;
                case nameof(ChecklistGoal):
                    if (int.TryParse(parts[5], out int completionCount) &&
                        int.TryParse(parts[6], out int targetCount) &&
                        int.TryParse(parts[7], out int bonusPoints))
                    {
                        goals.Add(new ChecklistGoal(name, value, targetCount, bonusPoints, description, completed, completionCount));
                    }
                    break;
                default:
                    Console.WriteLine($"Unknown goal type '{goalType}'. Skipping.");
                    break;
            }
        }
        else
        {
            Console.WriteLine($"Invalid line format: {line}. Skipping.");
        }
    }

    static void RecordEvent()
    {
        Console.Write("Enter the name of the goal to record an event: ");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name == goalName);

        if (goal != null)
        {
            goal.RecordCompletion();
            totalPoints += goal.Value;

                // Check if the goal is a ChecklistGoal and add bonus points if necessary
                if (goal is ChecklistGoal checklistGoal && checklistGoal.CompletionCount == checklistGoal.TargetCount)
                {
                    totalPoints += checklistGoal.BonusPoints;
                }
                
            Console.WriteLine($"Event recorded for {goalName}. You earned {goal.Value} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found. Event recording failed.");
        }
    }
}
