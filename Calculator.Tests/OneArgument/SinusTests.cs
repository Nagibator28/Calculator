using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 0)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Sinus();
            var testresult = calculator.Calculate(argument);
            Assert.AreEqual(result, testresult);

        }
    }
}