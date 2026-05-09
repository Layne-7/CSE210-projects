using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?"); // This prints the message
        string userAnswer = Console.ReadLine(); // This gets the user answer
        int percentage = int.Parse(userAnswer); // This turns the user answer into an int

        string letterGrade = ""; // An empty variable that will store a string as it updates

        if (percentage >= 90) // Conditions are made using parenthesis
        {
            letterGrade = "A";
        }

        else if (percentage >= 80) // if percentage is greater than 80, then you get a "B"
        {
            letterGrade = "B";
        }

        else if (percentage >= 70)
        {
            letterGrade = "C";
        }

        else if (percentage >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("You did not make it...Good luck next time, you'll make it!");
        }
    }
}