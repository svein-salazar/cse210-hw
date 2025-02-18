using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nCreate a New Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a goal type: ");

        string choice = Console.ReadLine();
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target number of times to complete the goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Select a goal to record: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayProgress()}");
        }
        Console.WriteLine();
    }

    static void ShowScore()
    {
        Console.WriteLine($"\nYour current score is: {score} points");
    }

    static void SaveGoals()
    {
        // Placeholder for saving functionality
        Console.WriteLine("Saving goals... (not implemented)");
    }

    static void LoadGoals()
    {
        // Placeholder for loading functionality
        Console.WriteLine("Loading goals... (not implemented)");
    }
}
