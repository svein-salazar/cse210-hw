using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random random = new Random();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(new Entry(date, prompt, response));
            }
            else if (option == "2")
            {
                journal.DisplayJournal();
            }
            else if (option == "3")
            {
                Console.Write("Enter the filename to save the journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (option == "4")
            {
                Console.Write("Enter the filename to load the journal: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (option == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            Console.WriteLine();
        }
    }
}
