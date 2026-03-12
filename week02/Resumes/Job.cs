using System;

public class Job // Creating a public class called Job
{
    public string _jobTitle; // Creating a public string variable that will get the job title in this class
    public string _company; // Creating a public string variable that will get the company's name that belongs to this class
    public int _startYear; // Creating a public int variable that will get the start year 
    public int _endYear; // Creating a public int variable that will get the end year

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); // Displaying the info
    }
}