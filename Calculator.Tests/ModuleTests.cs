using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class ModuleTests
    {
        [TestCase(-24,24)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Module();
            var testresult = calculator.Calculate(argument);
            Assert.AreEqual(result, testresult);

        }
    }
}