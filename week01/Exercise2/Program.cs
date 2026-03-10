using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userAnswer = Console.ReadLine();
        int percentage = int.Parse(userAnswer);

        string letterGrade = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }

        else if (percentage >= 80)
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