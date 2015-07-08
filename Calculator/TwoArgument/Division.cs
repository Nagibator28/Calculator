using System;

namespace Calculator.TwoArgument
{
    public class Division : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Divizion by zero");
            }
            else
            {
                return firstArgument/secondArgument;
            }
        }
    }
}
