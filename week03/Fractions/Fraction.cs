public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() // constructor that has no parameters that init the number to 1/1
    {
        _top = 1;
        _bottom = 1; 
    }

    public Fraction(int wholeNumber) // constructor that has one parameter for the top 
    // and that initializes the denominator to 1. 
    {
        _top = wholeNumber; // nominator 
        _bottom = 1; // denominator 
    }

    public Fraction(int top, int bottom) // constructor that has two parameters, one for 
    // the top and one for the bottom.
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() // getter
    {
        return _top;
    }

    public void SetTop(int top) // setter 
    {
        _top = top;
    }

    public int GetBottom() // getter
    {
        return _bottom;
    }

    public void SetBottom(int bottom) // setter 
    {
        _bottom = bottom;
    }

    public string GetFractionString() // this a method or function
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    public double GetDecimalValue() // this is a method or function
    {   // double makes possible to turn values into decimals
        double calculus = (double)_top / _bottom;
        return calculus;
    }

}