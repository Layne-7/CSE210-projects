public class PromptGenerator
{
    // This is a list of prompts to be generated randomly
    List <string> _prompts = new List<string> // Creating a new empty list to store prompts
    {
        "How was your day?", // prompt 1
        "What made you smile today?", // prompt 2
        "Who were you able to help today?", // prompt 3
        "What was one positive thought you had today?", // prompt 4 
        "What was one thing you could have done differently today?" // prompt 5
    };

    // This is a function that returns you a random question from the list
    public string GetRandomPrompt() 
    {
        Random random = new Random();
        // it randomly picks a number between 0 and the length of the list
        int index = random.Next(_prompts.Count); // Count gets the amount of items in _prompts
        return _prompts[index]; // the number randomly picked is returned
    }
}