using System;
using System.Threading;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        StartActivity();
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 6;
        }
        EndActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
