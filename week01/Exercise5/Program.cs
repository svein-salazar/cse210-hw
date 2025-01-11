using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcomeMsg();

        string Name = PromptName();
        int favoriteNumber = PromptNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(Name, squaredNumber);
    }

    static void DisplayWelcomeMsg()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
