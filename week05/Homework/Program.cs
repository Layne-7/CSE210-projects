using System;

class Program
{
    static void Main(string[] args)
    {   // testing out the classes creating instances for each one of them
        // This Assignment object takes 2 arguments (Student name, topic)
        Assignment test = new Assignment("Derek", "Math");
        Console.WriteLine(test.GetSummary()); // this method belongs to this class
        
        // This MathAssignment object takes 4 arguments (name, title, section, problems)
        MathAssignment math = new MathAssignment("Layne", "Multiplication", "3", "1-4");
        Console.WriteLine(math.GetHomeworklist());
        Console.WriteLine(math.GetSummary()); // this method belongs to the Assignment class
        // but inheritance is applied here, so this is a derived class from, allowed to use methods from
        // the class Assignment (base class)

        // This WritingAssignment object takes 3 arguments (Student name, topic, title)
        WritingAssignment writingTest = new WritingAssignment("Derek Layne", "Fractions", "How to Fraction");
        Console.WriteLine(writingTest.GetWritingInfomation());
        Console.WriteLine(writingTest.GetSummary());
    }
}