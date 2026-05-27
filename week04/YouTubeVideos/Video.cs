using System.ComponentModel.DataAnnotations;

public class Video
{   
    // Creating the attributes
    private string _title;
    private string _author;
    private int _length;
    public List<Comments> _comments;

    // Creating the constructor
    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>(); // every time a new object is created, it'll have its own
        // list of comments, data type being of the Comments class
    }

    // This methods iterates over the Comments list and returns the total number of comments for a video
   public int NumberOfComments()
    {   
        int comments = _comments.Count();
        return comments;
    }


    // This methods is made for knowing and setting up how you want to print your output
    // In this exercise, i'm supposed to display the title, author and length
    public string GetDisplay()
    {   
        string title = _title;
        string author = _author;
        int timeconvert = _length / 60; // this line turns seconds into minutes


        return $"Title: {title}\nAuthor: {author}\nLength: {timeconvert} Min";
    }
}