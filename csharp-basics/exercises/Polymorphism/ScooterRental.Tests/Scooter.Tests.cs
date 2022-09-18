using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ScooterTests
    {
        private Scooter _scooter;

        [TestMethod]
        public void CreateScooter_IDAndPricePerMinuteSetCorrectly()
        {
            // Arange
            _scooter = new Scooter("1", 0.2m);

            // Act
            var id = _scooter.Id;
            var pricePerMinute = _scooter.PricePerMinute;
            var isRented = _scooter.IsRented;

            //Assert
            id.Should().Be("1");
            pricePerMinute.Should().Be(0.2m);
            isRented.Should().BeFalse();
        }
    }
}