using System;

class Program
{
    static void Main(string[] args)
    {
        // Generating a random number using Random;
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}