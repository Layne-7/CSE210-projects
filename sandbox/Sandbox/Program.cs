using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("Hey, the girl i like just dumped me!...");
        Console.WriteLine("Now i gotta lift harder i guess...");

        Console.WriteLine(); // Space between outputs

        int number = 5;
        number = 8;
        number = number + 3;

        Console.Write("What is your favorite color? ");
        Console.WriteLine();

        string color = Console.ReadLine();
        Console.WriteLine($"Your color is {color}");
    }
}