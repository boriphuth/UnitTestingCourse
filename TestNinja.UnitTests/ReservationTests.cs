using System;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        // public void MethodOnTest_Scenarion_ExpectedBehaviour {}
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Tripple A
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void CanBeCancelldBy_UserIsCreator_ReturnsTrue()
        {
            var reservation = new Reservation();

            var user = new User();
            reservation.MadeBy = user;

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdminAndNotCreator_ReturnsFalse()
        {
            var reservation = new Reservation();
            var user = new User() { IsAdmin = false };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsFalse(result);
        }
    }
}
