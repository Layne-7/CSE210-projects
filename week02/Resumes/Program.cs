using System;

class Program
{
    static void Main(string[] args)
    {
        // From my class Job im creating a object that belongs to it
        Job job1 = new Job();
        // And these are the variables that belongs to my object Job1
        job1._jobTitle = "Software Engineer"; // Variable that shows the Job title
        job1._company = "Microsoft"; // Variable that shows the company 
        job1._startYear = 2019; // Variable that shows the start year
        job1._endYear = 2022; // Variable that shows the end year

        Job job2 = new Job(); // From my class Job created on the other file and made public, im creating a second object
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume(); // From my class Resume created on the other file and made public, created an object
        myResume._name = "Allison Rose"; // The class only has one public variable called _name

        // I created a list on the resume file and also made a foor loop in order for me to add jobs into the list
        myResume._jobs.Add(job1); // _jobs is the empty list, and now im using the object myResume to add a job into the list
        myResume._jobs.Add(job2);

        myResume.Display(); // Displaying
    }
}