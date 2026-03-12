using System;

public class Resume
{
    public string _name; // This creates a variable called _name in this Resume class 

    public List<Job> _jobs = new List<Job>(); // This creates a list called _jobs

    public void Display() // this returns none
    {
        Console.WriteLine($"Name: {_name}"); // This prints the name
        Console.WriteLine("Jobs:"); // This prints the Jobs

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}