using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Creating the journal object
        PromptGenerator generator = new PromptGenerator(); // creating the generator object

        bool running = true; // while this is true, the program will keep running

        while (running) // a while loop to keep the program running
        {   // printing the options
            Console.WriteLine("1 - New entry");
            Console.WriteLine("2 - Display Journal");
            Console.WriteLine("3 - Save");
            Console.WriteLine("4 - Load");
            Console.WriteLine("5 - Quit");
            Console.WriteLine("What would you like to do?");

            // Conseole.ReadLine reads what the user typed and stores it in the variable choice
            string choice = Console.ReadLine();

            switch (choice) // swtich works just like if-else, but using cases
            {
                case "1": // if the user types 1, then:
                    string prompt = generator.GetRandomPrompt(); // a prompt is generated
                    Console.WriteLine($"{prompt}"); // displaying the prompt
                    Console.Write("Answer: "); // space for the user's answer
                    string answer = Console.ReadLine(); // reads the users answer and stores it in a variable called answer
                    string date = DateTime.Now.ToString("MM/dd/yyyy"); // gets the current date as a string

                    // Creates a new entry with date, prompot and answer, add into the journal.
                    Entry entry = new Entry(date, prompt, answer);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry Added!"); // displays that the entry was added.
                    break; // break is needed when using switch and case.

                case "2": // if the user types 2, then:
                    journal.DisplayAll(); // It displays all the entries saved in the memory
                    break;

                case "3": // if the user types 3, then:
                    Console.Write("File name: "); // asks for the file name
                    string saveFile = Console.ReadLine(); // read the users answer
                    journal.SaveToFile(saveFile); // save the journal in this file
                    break;

                case "4": // if the user types 4, then:
                    Console.Write("File name: "); // asks for the file name
                    string loadFile = Console.ReadLine(); // reads the file name and stores it into the variable
                    // this is just like try and except in python
                    // it tries to load the entries from the file and then displays them all
                    try
                    {
                        journal.LoadFromFile(loadFile); // Load all the entries from the file
                        journal.DisplayAll(); // displaying all the entries saved in the file.
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("File not found. Check the file's name and try again.");
                    }
                    break;

                case "5": // if the user types 5, then:
                    running = false; // running becomes false and it stops the program
                    break;

                default: // if the user types something different than 1,2,3,4,5
                Console.WriteLine("Invalid Option."); // it'll display this message.
                break;

            }
        }
    }
}