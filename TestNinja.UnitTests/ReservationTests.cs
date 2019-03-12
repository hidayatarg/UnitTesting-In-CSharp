using System;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange (Prepare object we test)
            var reservation = new Reservation();
            
            // Act (Call method we want to test)
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true } );

            // Asset (result and verify its correct)
            //Assert.IsTrue(result);

            // OR
            Assert.That(result, Is.True);
            //Assert.That(result==true);
             
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            var user = new User();
            // Arrange
            var reservation = new Reservation{MadeBy = user};

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation{MadeBy = new User()};
            // Act
            var result = reservation.CanBeCancelledBy(new User());
            // Assert
            Assert.IsFalse(result);
        }
    }
}
