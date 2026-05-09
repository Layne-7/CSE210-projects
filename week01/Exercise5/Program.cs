using System;

class Program
{
    // We should use static when creating our functions before we start using classes...
    static void Main(string[] args) // This is basically the main function
    {
        DisplayWelcomeMessage(); // Calling the function

        string userName = PromptUserName(); // storing the name given on the function in a variable
        int userNumber = PromptUserNumber(); // storing the number given on the function in a variable

        int squaredNumber = SquareNumber(userNumber); // storing the squared number in a variable

        DisplayResult(userName, squaredNumber); // display the result calling the function
    }

    // Void means the function returns nothing - it just does something and finishes.
    static void DisplayWelcomeMessage() // creating the function. Note: no need to add colon.
    {
        Console.WriteLine("Welcome to the program!"); // printing the welcome message
    }

    static string PromptUserName() // functions need to have their data type defined as well
    {
        Console.Write("Please enter your name: "); // getting the users name
        string name = Console.ReadLine(); // reading the user name and storing it to a variable

        return name; // returning the result of the function
    }

    static int PromptUserNumber() // This function data type is int
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number; // squaring the number by multiplying
        return square; // returing the result of multiplication, which is a squared number
    }

    static void DisplayResult(string name, int square) // void function
    {   
        // Displaying the message
        Console.WriteLine($"{name}, the square of your number is {square}"); 
    }
}