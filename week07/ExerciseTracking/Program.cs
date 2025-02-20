using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        var running = new Running(new DateTime(2025, 2, 5), 30, 3.0);
        var cycling = new Cycling(new DateTime(2025, 2, 4), 45, 15.0);
        var swimming = new Swimming(new DateTime(2025, 2, 3), 20, 30);

        // Add activities to list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
