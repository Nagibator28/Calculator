using System;

namespace Calculator.TwoArgument
{
    public static class TwoArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Addition":
                    return new Addition();
                    break;
                case "Division":
                    return new Division();
                    break;
                case "Multiplication":
                    return new Multiplication();
                    break;
                case "Subtraction":
                    return new Subtraction();
                    break;
                case "Pow":
                    return new Pow();
                    break;
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
