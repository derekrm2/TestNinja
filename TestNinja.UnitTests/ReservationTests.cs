using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() // method being tested, scenario, expected behaviour
        {
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            // assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation{MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            var joe = new User();
            var dave = new User();

            var reservation = new Reservation {MadeBy = joe};

            var result = reservation.CanBeCancelledBy(dave);

            Assert.That(result, Is.False);
        }
    }
}
