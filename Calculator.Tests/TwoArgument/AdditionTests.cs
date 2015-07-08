using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.TwoArgument;

namespace Calculator.Tests.TwoArgument
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 6, 9)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Addition();
            var testresult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testresult);

        }
    }
}