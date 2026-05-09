using System;

class Program
{
    static void Main(string[] args)
    {
        // Generating a random number using Random;
        Random randomNumber = new Random(); // using the class Random 
        int magicNumber = randomNumber.Next(1, 100); // Getting the next integer 

        int userGuess = -1; // setting up a variable before so we can always start the loop.

        while (userGuess != magicNumber)
        {   // Console.Write prints the message
            Console.Write("What is your guess? ");
            // Console.ReadLine() reads the user message on the terminal
            //int.Parse turns the string into an integer number in order to compare guesses.
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