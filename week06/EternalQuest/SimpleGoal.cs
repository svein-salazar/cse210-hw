using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public override void RecordEvent()
    {
        IsComplete = true;
        Console.WriteLine($"You completed the goal '{Name}' and earned {Points} points!");
    }

    public override string DisplayProgress()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name}";
    }
}
