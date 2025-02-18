using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; protected set; }

    public abstract void RecordEvent();
    public abstract string DisplayProgress();
}
