public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Breathe out... ");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}