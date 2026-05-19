using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction test = new Fraction();
        test.SetTop(3);
        test.SetBottom(4);

        // decided to do this for a better understanding of access modifiers
        // due to its protection level (private), i can't change its value, that is for 
        // data integrity of the code. That is why we need getters and setters.
       // test._top = 0

        Console.WriteLine($"Output: {test.GetTop()}/{test.GetBottom()}");
        Console.WriteLine($"Final result: {test.GetDecimalValue()}");
    }
}