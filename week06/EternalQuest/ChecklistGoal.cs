using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
    {
        Name = name;
        Points = points;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
        IsComplete = false;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"You completed a session of '{Name}' and earned {Points} points!");

        if (_currentCount >= _targetCount)
        {
            IsComplete = true;
            Console.WriteLine($"Congratulations! You completed '{Name}' and earned a bonus of {_bonusPoints} points!");
        }
    }

    public override string DisplayProgress()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} (Completed {_currentCount}/{_targetCount} times)";
    }
}
