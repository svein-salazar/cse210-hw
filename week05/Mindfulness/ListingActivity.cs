using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : BaseActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        StartActivity();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        Console.WriteLine("You will have a few seconds to prepare...");
        ShowSpinner(5);

        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}
