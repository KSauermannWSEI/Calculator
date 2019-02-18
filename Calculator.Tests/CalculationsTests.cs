using System;
using NUnit.Framework;
using Moq;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculationsTests
    {
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 5)]
        [TestCase(2, 4, 6)]
        [TestCase(2.5, 1, 3.5d)]
        public void Add_AddsTwoDouble_ReternsInt(double a, double b, double c)
        {
            Calculations calculations = new Calculations();
            Assert.AreEqual(c, calculations.Add(a, b));            
        }
    }
}
