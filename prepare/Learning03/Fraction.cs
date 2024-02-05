class Fraction
{
     private int _top;
     private int _bottom;

     public Fraction()
     {
        _top = 1;
        _bottom = 1;
     }

     public Fraction(int wholeNumber)
     {
        _top = wholeNumber;
        _bottom = 1;
     }

     public Fraction(int numerator, int denominator)
     {
        _top =  numerator;
        _bottom = denominator;
     }

     public string GetFractionString()
     {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
     }

     public double GetDecimalValue()
     {
        double number = _top / _bottom;
        return number;
     }
    
}