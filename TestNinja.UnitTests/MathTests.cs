﻿using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
   public class MathTests
    {
        private Math _math;
        // step initialized before each method
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        // for add method
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange
           
            // Act 
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        // for returning max 
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));

        }        
    }

}
