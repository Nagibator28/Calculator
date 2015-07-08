using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.TwoArgument;

namespace Calculator.Tests.TwoArgument
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 6, 18)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Multiplication();
            var testresult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testresult);

        }
    }
}