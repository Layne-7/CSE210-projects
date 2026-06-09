public class Square : Shape // Inheriting the base class
{
    // attributes
    private double _side;

    // This is the Constructor for this derived class
    // it is calling the constructor from the base class
    public Square(string color, double side) : base(color)
    {
        // We'll add the side attribute for this class constructor
        _side = side;
    }

    // Now we're overriding the method, in other words, we're adapting it for this class.
    public override double GetArea()
    {

        return _side * _side;
    }
}