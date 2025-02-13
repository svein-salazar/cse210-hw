using System;
using System.Threading;

public abstract class BaseActivity
{
    protected string ActivityName { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {ActivityName}...");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {ActivityName} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
