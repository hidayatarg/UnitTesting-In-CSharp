using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange (Prepare object we test)
            var reservation = new Reservation();
            
            // Act (Call method we want to test)
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true } );

            // Asset (result and verify its correct)
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_TheSameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User();
            // Arrange
            var reservation = new Reservation{MadeBy = user};

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingRerservation_ReturnsFalse()
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
