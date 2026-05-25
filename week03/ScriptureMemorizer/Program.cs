using System;

class Program
{
    static void Main(string[] args) 
    {
        // THESE ARE ALL SHORT TESTS 
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //Reference test = new Reference("1 Nephi", 3, 7);
        //Console.WriteLine(test.GetDisplayText());

        //Word w = new Word("Savior"); // Creating an Object/instance 1
        //w.Show(); // testing methods
        //Console.WriteLine(w.GetDisplayText()); // our display method
        //Console.WriteLine($"Is it a hidden word? {w.IsHidden()}"); // checking whether its false or true

        //Console.WriteLine(); // space

        //Word w2 = new Word("Monster"); //  Creating an Object/instance 2
        //w2.Hide(); // testing methods
        //Console.WriteLine(w2.GetDisplayText()); // our display method
        //Console.WriteLine($"Is it a hidden word? {w2.IsHidden()}");

        //Scripture s = new Scripture(test, "I will go and do");
        //s.HideRandomWords(2);
        //Console.WriteLine(s.GetDisplayText());


        // Creating the instance 
        Reference reference = new Reference("John", 3, 6);

        Scripture scripture = new Scripture(
            reference, "For God so loved the world that He gave his one and only Son"
        );

        while (!scripture.isCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue or type quit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }
        

    }
}