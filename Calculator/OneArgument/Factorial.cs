using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
