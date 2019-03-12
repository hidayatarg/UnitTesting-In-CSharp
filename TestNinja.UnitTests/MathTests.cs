using NUnit.Framework;
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
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(2, 2);
            Assert.That(result, Is.EqualTo(2));
        }
    }

   internal class _math
   {
   }
}
