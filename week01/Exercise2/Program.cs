using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter = "";
        //Stretch challenge
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Determine the "+" or "-" sign
        if (letter != "F" && letter != "A")
        {
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special Cases for A and F
        if (letter == "A" && gradePercentage >= 90 && gradePercentage < 93)
        {
            sign = "-"; // A- case
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        // Display the letter grade with the sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the student passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }
    }
}
