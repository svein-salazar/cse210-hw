using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false; // Always false for eternal goals
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You completed a session of '{Name}' and earned {Points} points!");
    }

    public override string DisplayProgress()
    {
        return $"[ ] {Name} (Eternal Goal)";
    }
}
