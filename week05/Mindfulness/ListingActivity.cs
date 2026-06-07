public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "List as many items as you can in the time.")
    {
        _prompts = new List<string>
        {
            "Who are people that you admire?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(5);
        _count = 0;
        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        var items = new List<string>();
        string input;
        while ((input = Console.ReadLine()) != "")
            items.Add(input);
        return items;
    }
}