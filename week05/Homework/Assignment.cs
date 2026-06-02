public class Assignment // This is the base class
{
    // Creating the attributes
    // protected access modifier allows derived classes to access the attributes in this class
    protected string _studentName;
    protected string _topic;

    // Creating the constructor
    public Assignment (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Creating the method to display the summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }


}