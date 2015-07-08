namespace Calculator.TwoArgument
{
    public class Addition : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
