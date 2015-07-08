using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class FactorialTests
    {
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Factorial();
            var testresult = calculator.Calculate(argument);
            Assert.AreEqual(result, testresult);

        }
    }
}