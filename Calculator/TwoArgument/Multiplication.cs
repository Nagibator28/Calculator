﻿namespace Calculator.TwoArgument
{
    public class Multiplication : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
