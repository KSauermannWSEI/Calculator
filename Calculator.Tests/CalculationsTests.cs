using System;
using NUnit.Framework;
using Moq;
using Calculator.Abstract;
using System.Collections.Generic;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculationsTests
    {
        private Calculations calculations;

        [SetUp]
        public void Init()
        {
            var repoMock = new Mock<IRepo>();
            repoMock.Setup(s => s.GetValues()).Returns(new List<int> { 10, 20, 30 });
            var repo = repoMock.Object;
            calculations = new Calculations(repo);
        }
        [Test]
        public void GetFirst_Returns10()
        {
            var result = calculations.GetFirst();
            Assert.AreEqual(10, result);
        }


        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 5)]
        [TestCase(2, 4, 6)]
        [TestCase(2.5, 1, 3.5d)]
        public void Add_AddsTwoDouble_ReternsDouble(double a, double b, double c)
        {            
            Assert.AreEqual(c, calculations.Add(a, b));            
        }
        [Test]
        [TestCase(2, 2, 0)]
        [TestCase(2, -2, 4)]
        [TestCase(-2, -2, 0)]
        public void Substract_SubstractsTwoDouble_ReturnsDouble(double a, double b, double c)
        {         
            Assert.AreEqual(c, calculations.Substract(a, b));
        }
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(2, -1, -2)]
        [TestCase(-2, -2, 4)]
        public void Multiple_ReturnsDouble(double a, double b, double c)
        {            
            Assert.AreEqual(c, calculations.Multiple(a, b));
        }

        [Test]
        [TestCase(2, 2, 1)]
        [TestCase(2, -1, -2)]
        [TestCase(-2, -2, 1)]        
        public void Divide_SecondParameterNotZero_ReturnsDouble(double a, double b, double c)
        {           
            Assert.AreEqual(c, calculations.Divide(a, b));
        }
        [Test]
        [TestCase(-2, 0)]
        public void Divide_SecondParameterZero_ReturnsDouble(double a, int b)
        {                   
            Assert.Throws(typeof(DivideByZeroException), () => calculations.Divide(a, b));
        }
    }
}
