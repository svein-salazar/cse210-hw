using System;
using System.Collections.Generic;

public class ReflectionActivity : BaseActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        ActivityName = "Reflection Activity";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Run()
    {
        StartActivity();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        ShowSpinner(3);
        
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]);
            ShowSpinner(5);
            elapsedTime += 5;
        }
        EndActivity();
    }
}
