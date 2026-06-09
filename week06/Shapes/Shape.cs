using System.Drawing;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public abstract class Shape // This class is an abstract one because it has an abstract method 
{
    // Attributes
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // This is the getter for the attribute color
    public string Getcolor()
    {
        return _color;
    }

    // This is the setter for attribute color
    public void SetColor(string color)
    {
        _color = color;
    }

    // This is an abstract method, as to apply polymorphism, we'll leave it this way so we can
    // override it in other derived classes
    public abstract double GetArea();
}