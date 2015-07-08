using System;

namespace Calculator.OneArgument
{
    public class Module : ISingleOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
