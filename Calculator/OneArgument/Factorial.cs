namespace Calculator.OneArgument
{
    public class Factorial : ISingleOperation
    {
        public double Calculate(double firstArgument)
        {
            double result = 1;
            for (int i = 1; i < firstArgument; i++)
            {
                result *= i+1;
            }
            return result;
        }
    }
}
