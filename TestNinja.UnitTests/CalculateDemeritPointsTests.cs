using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CalculateDemeritPointsTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;

        [SetUp]
        public void SetUp()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        // my solutions
        [Test]
        [TestCase(65,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        [TestCase(80,3)]
        [TestCase(0,0)]
        [TestCase(60,0)]
        [TestCase(66,0)]
        public void CalculateDemeritPoints_WhenCalled_ReturnsExpectedInt(int speed, int expectedResult)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowsException(int speed)
        {
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}
