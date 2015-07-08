﻿using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator.OneArgument;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0,1)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Cosinus();
            var testresult = calculator.Calculate(argument);
            Assert.AreEqual(result, testresult);

        }
    }
}