using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   // List <Data Type> variable = new List <Data Type> (); Creating an Object and a list
        List<int> numbers = new List<int>(); // Variable numbers holds an empty list
        
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (Type 0 to quit): "); // Print statement
            
            string userResponse = Console.ReadLine(); // Reading the user answer
            userNumber = int.Parse(userResponse); // Variable stores and turns string into number
            
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber); // Adding the user number into the list using Add
            }
        }

        
        int sum = 0; // Creating a variable called sum, initially starting with 0
        foreach (int number in numbers) // for each number in my list numbers, then...
        {
            sum += number; // 0 + user number, it will store a new value each iteration.
        }

        Console.WriteLine($"The sum is: {sum}"); // This displays the final result of the sum

        // sum is now a float datatype and im getting the size of the list numbers using Count
        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average}"); // printing the average

        
        
        int max = numbers[0]; // getting the first item of the list to compare

        foreach (int number in numbers) // for each number in my list of numbers, then...
        {
            if (number > max)
            {
                
                max = number; // if the number on that iteration is greater the max, he becomes the max.
            }
        }

        Console.WriteLine($"The max is: {max}"); // printing the max
    }
}