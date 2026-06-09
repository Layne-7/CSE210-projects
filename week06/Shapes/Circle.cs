public class Circle : Shape // Derived class
{
    // attributes
    private double _radius;

    // Constructor for this class, also calling the base class constructor
    public Circle(string color, double radius) : base(color)
    {
        // Adding the radius attribute as its needed for the circle area calculation
        _radius = radius;
    }

    // Overriding the base class method (its an abstract method), so we can apply it for this class
    public override double GetArea()
    {
        double pi = 3.14;
        return pi * (_radius * _radius);
    }
}