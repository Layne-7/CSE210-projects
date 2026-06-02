using System.Linq.Expressions;

public class MathAssignment : Assignment
// MathAssignment is a derived class and it is inheriting attributes and behaviors from the base class
// The base class is Assignment.cs
{   
    // Creating the attributes
    private string _textbookSection;
    private string _problems;

    // Creating the MathAssignment constructor
    // As this is a derived class, when we use base(StudentName, topic), we are calling the attributes from
    // the base class (Assignment), thus, in this class we'll only need to add 2 more attributes.
    public MathAssignment (string studentName, string topic, string textbooksection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    // Creating the method to display the homework list
    public string GetHomeworklist()
    {
        return $"{_studentName} - {_topic}\nSection: {_textbookSection} Problems {_problems}";
    }


}