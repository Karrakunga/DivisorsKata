﻿using DivisorsKata;
using NUnit.Framework;

namespace DivisorKata.Tests.Unit
{
    [TestFixture]
    public class DivisorCalculatorTests
    {
        private DivisorCalculator _divisorCalculator;

        [OneTimeSetUp]
        public void GivenADivisorCalculator()
        {
            _divisorCalculator = new DivisorCalculator();
        }

        [TestCase(1, new[] { 1 })]
        [TestCase(2, new[] { 1, 2 })]
        [TestCase(3, new[] { 1, 3 })]
        [TestCase(4, new[] { 1, 2, 4 })]
        [TestCase(20, new[] { 1, 2, 4, 5, 10, 20 })]
        [TestCase(30, new[] { 1, 2, 3, 5, 6, 10, 15, 30 })]
        public void WhenCalculateIsCalledThenTheExpectedResponseIsReturned(int inputNumber, int[] expectedResponse)
        {
            var response = _divisorCalculator.Calculate(inputNumber);
            Assert.That(response, Is.EqualTo(expectedResponse));
        }

    }
}
