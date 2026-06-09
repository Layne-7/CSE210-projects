using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape // Derived class
{
    // attributes
    private double _length;
    private double _width;

    // This is the constructor for this class, we're also calling the base class constructor (base(color))
    public Rectangle(string color, double length, double width) : base(color)
    {
        // Adding length and width for this constructor, as its needed for the calculation
        _length = length;
        _width = width;
    }

    // Overriding the abstract base class method (its a must)
    public override double GetArea()
    {
        return _length * _width;
    }
}