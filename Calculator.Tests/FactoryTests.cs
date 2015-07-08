using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class FactoryTests
    {
        [TestCase(typeof (Addition), "Addition")]
        [TestCase(typeof (Division), "Division")]
        [TestCase(typeof (Pow), "Pow")]
        [TestCase(typeof (Subtraction), "Subtraction")]
        [TestCase(typeof (Multiplication), "Multiplication")]

        public void FactoryTest(Type type, string name)
        {
            Type resultType = TwoArgumentFactory.CreateCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }
    }
}