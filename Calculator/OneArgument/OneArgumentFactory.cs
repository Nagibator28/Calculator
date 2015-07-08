using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgument
{
    class OneArgumentFactory
    {
        public static ISingleOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Sinus": 
                    return new Sinus();
                    break;
                case "Module": 
                    return new Module();
                    break;
                case "Cosinus":
                    return new Cosinus();
                    break;
                case "Factorial":
                    return new Factorial();
                    break;
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
