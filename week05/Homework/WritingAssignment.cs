public class WritingAssignment : Assignment
// WritingAssignment is a derived class and it is inheriting attributes and behaviors from the base class
// The base class is Assignment.cs
{
    // As this is a derived class, we'll only need to add a title attribute, as we'll be reusing 
    // the other attributes from the base class (Assignment)
    private string _title;

    // Creating the constructor resuing the attributes from the base class (base(studentName, topic))
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Creating the method to get the writing information 
    public string GetWritingInfomation()
    {
        return $"{_title} by {_studentName}";
    }
}