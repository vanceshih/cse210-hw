using System;

public class Fraction
{
    private int _top;
    private int _bottom;

        public Fraction()
        {
            //no parameters that initializes the number to 1/1
            _top = 1;
            _bottom =1;
        }
        public Fraction(int wholeNumber)
        {
            //one parameter for the top and that initializes the denominator to 1
            _top = wholeNumber;
            _bottom = 1;
        }
        
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }

        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }


}