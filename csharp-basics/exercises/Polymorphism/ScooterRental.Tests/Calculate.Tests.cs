using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScooterRental.Tests
{
    [TestClass]
    public class CalculateTests
    {
        private RentalDetails _rentalDetail;

        [TestInitialize]
        public void Setup()
        {
            _rentalDetail = new RentalDetails("1", new DateTime(2022, 1, 1, 0, 0, 0), 0.2m);
        }

        [TestMethod]
        public void TotalRentalPrice_CalculatesRentalForAFullDayCorrectly_Returns20Euros()
        {
            // Arange
            _rentalDetail.EndTime = new DateTime(2022, 1, 1, 23, 59, 59);

            //Act
            var result = Calculate.TotalRentalPrice(_rentalDetail);

            //Assert
            result.Should().Be(20m);
        }

        [TestMethod]
        public void TotalRentalPrice_CalculatesRentalPriceBetweenTwoFullDays_Returns40Euros()
        {
            // Arange
            _rentalDetail.EndTime = new DateTime(2022, 1, 2, 23, 59, 59);

            // Act
            var result = Calculate.TotalRentalPrice(_rentalDetail);

            // Assert
            result.Should().Be(40m);
        }

        [TestMethod]
        public void TotalRentalPrice_CalculatesRentalPriceBetweenOneDayAndTwoMinutes_Returns20Euros4Cents()
        {
            // Arange
            _rentalDetail.EndTime = new DateTime(2022, 1, 2, 0, 2, 0);

            // Act
            var result = Calculate.TotalRentalPrice(_rentalDetail);

            // Assert
            result.Should().Be(20.4m);
        }

        [TestMethod]
        public void TotalRentalPrice_CalculatesRentalPriceBetweenTwoMinutesAndOneDay_Returns20Euros4Cents()
        {
            // Arange
            _rentalDetail.StartTime = new DateTime(2022, 1, 1, 23, 58, 0);
            _rentalDetail.EndTime = new DateTime(2022, 1, 3, 0, 0, 0);

            // Act
            var result = Calculate.TotalRentalPrice(_rentalDetail);

            // Assert
            result.Should().Be(20.4m);
        }

        [TestMethod]
        public void TotalRentalPrice_CalculatesRentalPriceBetweenFourDays_Returns80Euros()
        {
            // Arange
            _rentalDetail.StartTime = new DateTime(2022, 1, 1, 0, 0, 0);
            _rentalDetail.EndTime = new DateTime(2022, 1, 5, 0, 0, 0);

            // Act
            var result = Calculate.TotalRentalPrice(_rentalDetail);
            
            // Assert
            result.Should().Be(80m);
        }

        [TestMethod]
        public void RentPrice_CalculatesPriceFor20Minutes_Returns4Euros()
        {
            // Arange
            var minutes = 20;
            var pricePerMinute = 0.2m;

            // Act
            var result = Calculate.RentPrice(minutes, pricePerMinute);

            // Assert
            result.Should().Be(4m);
        }

        [TestMethod]
        public void RentPrice_CalculatesPriceFor200Minutes_Returns20Euros()
        {
            // Arange
            var minutes = 200;
            var pricePerMinute = 0.2m;

            // Act
            var result = Calculate.RentPrice(minutes, pricePerMinute);

            // Assert
            result.Should().Be(20m);
        }
    }
}
