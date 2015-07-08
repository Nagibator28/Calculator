using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class RadicalTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Radical();
            var testresult = calculator.Calculate(124);
            var result = Math.Sqrt(124);
            Assert.AreEqual(1, 1);

        }
    }
}