public class Entry
{
    // Attributes: These are the info that every entry holds
    public string _date;
    public string _promptText;
    public string _entryText;

    // this is basically a function just like in python
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display() // this is a function that returns nothing, it only displays stuff
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Answer: {_entryText}");
        Console.WriteLine();
    }
}