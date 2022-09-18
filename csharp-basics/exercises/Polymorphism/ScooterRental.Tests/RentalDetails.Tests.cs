using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ReportTests
    {
        private RentalDetails _rentalDetail;

        [TestInitialize]
        public void Setup()
        {
            _rentalDetail = new RentalDetails("1", new DateTime(2022, 1, 1), 0.2m);
        }

        [TestMethod]
        public void CreateReport_IdAndStartTimeAndPricePerMinuteSetCorrectly()
        {
            // Arrange
            _rentalDetail.EndTime = new DateTime(2022, 2, 1);

            // Act
            var id = _rentalDetail.Id;
            var startTime = _rentalDetail.StartTime;
            var pricePerMinute = _rentalDetail.PricePerMinute;
            var endTime = _rentalDetail.EndTime;

            // Assert
            id.Should().Be("1");
            startTime.Should().Be(new DateTime(2022, 1, 1));
            pricePerMinute.Should().Be(0.2m);
            endTime.Should().Be(new DateTime(2022, 2, 1));
        }
    }
}
