using System;

namespace Calculator.OneArgument
{
    public class Sinus : ISingleOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
