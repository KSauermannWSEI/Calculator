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
        public void Add_AddsTwoDouble_ReternsDouble(double a, double b, double c)
        {
            Calculations calculations = new Calculations();
            Assert.AreEqual(c, calculations.Add(a, b));            
        }
        [Test]
        [TestCase(2, 2, 0)]
        [TestCase(2, -2, 4)]
        [TestCase(-2, -2, 0)]
        public void Substract_SubstractsTwoDouble_ReturnsDouble(double a, double b, double c)
        {
            Calculations calculations = new Calculations();
            Assert.AreEqual(c, calculations.Substract(a, b));
        }
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(2, -1, -2)]
        [TestCase(-2, -2, 4)]
        public void Multiple_ReturnsDouble(double a, double b, double c)
        {
            Calculations calculations = new Calculations();
            Assert.AreEqual(c, calculations.Multiple(a, b));
        }

        [Test]
        [TestCase(2, 2, 1)]
        [TestCase(2, -1, -2)]
        [TestCase(-2, -2, 1)]        
        public void Divide_SecondParameterNotZero_ReturnsDouble(double a, double b, double c)
        {
            Calculations calculations = new Calculations();
            Assert.AreEqual(c, calculations.Divide(a, b));
        }
        [Test]
        [TestCase(-2, 0)]
        public void Divide_SecondParameterZero_ReturnsDouble(double a, int b)
        {
            Calculations calculations = new Calculations();           
            Assert.Throws(typeof(DivideByZeroException), () => calculations.Divide(a, b));
        }
    }
}
