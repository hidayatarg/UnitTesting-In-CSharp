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
    }
}
