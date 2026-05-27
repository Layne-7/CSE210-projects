using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Creating a List that will store only Video class instances/objects
        List<Video> _videos = new List<Video>();
        // Creating instances/objetcts

        // video 1 (Our construcor was built in a way that we can add a title, author and length)
        // that is, i've set it up to initialize with 3 arguments, one being an int data type
        Video video1 = new Video("How to make money", "Mr beast", 120);
        Comments comment1 = new Comments("Derek", "This video is interesting.");
        Comments comment2 = new Comments("Briana", "I'll get rich.");
        Comments comment3 = new Comments("Jane", "Awesome content, keep it up!");

        // As _comments is an empty list with "Comments" data type and its part of the
        // "video class" constructor, i can add as many comments as i want all at once 
        // in a single video instance, for this, just have to use the method .AddRange(new[] {...})
        video1._comments.AddRange(new[] {comment1, comment2, comment3});
    

        // video 2 - I created more Comments instances for the second video and added them to
        // the new comments list, as you create a new one every time a new object is created.
        Video video2 = new Video("How to learn coding", "Hashtag", 60);
        Comments comment4 = new Comments("John", "Thanks for the tips on C#");
        Comments comment5 = new Comments("Layne", "Now i can code a bit better...");
        Comments comment6 = new Comments("Matthew", "Great video!");
        video2._comments.AddRange(new[] {comment4, comment5, comment6});

        // video 3 - Same thing here
        Video video3 = new Video("Discipline pays off", "Carol Dweck", 180);
        Comments comment7 = new Comments("Hayley", "Thank you so much for this video");
        Comments comment8 = new Comments("Greg", "It could've been better explained...");
        Comments comment9 = new Comments("Amaya", "I've learned so much with this video!");
        video3._comments.AddRange(new[] {comment7, comment8, comment9});

        // this line stores all the video instances into the list i created at the top of the program
        // now i have a list of videos along with their list of comments.
        _videos.AddRange(new[] {video1, video2, video3});

        int count = 0; // this is a counter to enumerate something, it will be added one at each iteration
        foreach (Video video in _videos) // for each video in my list of "Video" data type
        {   
            count = count + 1;
            // video.GetDisplay is a method made in the Video class, and it displays the title,
            // author and length of each video
            Console.WriteLine($"     Video {count}\n{video.GetDisplay()}");

            // NumberOfComments is a method that iterates over every video's list and returns
            // the total number of comments on this specific video.
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine(); // space

            int count2 = 0; // second counter, but for comments

            // video._comments is a list with its data type being the "Comments Class",
            // so every item in it has its data type set as Comments
            foreach (Comments comment in video._comments)
            {
                count2 += 1;
                Console.WriteLine($"{count2}:\n{comment.GetDisplay()}");
                // As the class Comments has its own GetDisplay() method, we can use it to display
                // our output as defined in the method (name, text)       
            }
            Console.WriteLine();

        }



    }
}