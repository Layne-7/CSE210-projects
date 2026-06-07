using Microsoft.VisualBasic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "Reflect on moments of strength in your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time you stood up for someone.",
            "What is something you did really well this week?"
        };
        _questions = new List<string>
        {
            "Why was this meaningful to you?",
            "What did you learn from it?",
            "How did others benefit from your actions?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            DisplayQuestions();
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() =>
        _prompts[new Random().Next(_prompts.Count)];

    private string GetRandomQuestion()
    {
        return _questions[new Random().Next(_questions.Count)];
    } 
        
    private void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---\n");
    }

    private void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }
}
