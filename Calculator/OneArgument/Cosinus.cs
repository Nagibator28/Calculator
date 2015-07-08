using System;

namespace Calculator.OneArgument
{
    public class Cosinus : ISingleOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
