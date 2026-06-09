using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Shape> shapes = new List<Shape>(); // This is a list that stores shapes objects in general
        //Console.WriteLine("Hello World! This is the Shapes Project.");

       Square square = new Square("Purple", 5); // This is a Square instance
       //Console.WriteLine($"{square.Getcolor()}, {square.GetArea()}");

       Rectangle rectangle = new Rectangle("Blue", 5, 3); // This is Rectangle Instance
       //Console.WriteLine($"{rectangle.Getcolor()}, {rectangle.GetArea()}");

       Circle circle = new Circle("Green", 3); // This is a circle Instance
       //Console.WriteLine($"{circle.Getcolor()}, {circle.GetArea()}");

       shapes.AddRange(square, rectangle, circle); // Adding all instances into the shapes list

       foreach (Shape shape in shapes) // for each shape in the list, it'll display its color and area
        {
            string color = shape.Getcolor(); // displaying color

            double area = shape.GetArea(); // displaying its area (because we've overridden this method
            // it will pull the correct area calculation for each shape)

            Console.WriteLine($"The {color} shape has the following area: {area}");

        }
    }
}