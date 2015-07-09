﻿using Calculator.SortingOfMassiv;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfMassiv
{
    [TestFixture]
    class SelectionSortingTests
    {

        [TestCase(new double[] { 12, -3, 0 }, new double[] { -3, 0, 12 })]
        public void Calculate(double[] argument, double[] result)
        {
            var sort = new SelectionSorting();
            var testResult = sort.Sort(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}