using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.TwoArgument;

namespace Calculator.Tests.TwoArgument
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(3, 6, 0.5)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Division();
            var testresult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testresult);

        }
    }
}