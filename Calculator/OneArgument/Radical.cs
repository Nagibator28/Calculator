using System;

namespace Calculator.OneArgument
{
    public class Radical : ISingleOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}
