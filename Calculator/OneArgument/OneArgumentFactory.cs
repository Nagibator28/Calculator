using System;

namespace Calculator.OneArgument
{
    public static class OneArgumentFactory
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
                case "Radical":
                    return new Radical();
                    break;
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
