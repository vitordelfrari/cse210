using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Constructor with no parameters, initializes the fraction to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        // Constructor with one parameter for the top, initializes denominator to 1
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
         // Constructor with two parameters, one for the top and one for the bottom
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}