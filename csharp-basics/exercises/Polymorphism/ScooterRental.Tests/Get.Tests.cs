using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental.Helper;

namespace ScooterRental.Tests
{
    [TestClass]
    public class GetTests
    {
        private Scooter _scooter;
        private IList<Scooter> _scooters;

        [TestInitialize]
        public void Setup()
        {
            _scooter = new Scooter("1", 0.2m);
            _scooters = new List<Scooter> { _scooter };
        }

        [TestMethod]
        public void Scooter_GetsAValidScooter()
        {
            // Act
            var result = Get.Scooter("1", _scooters);

            // Assert
            result.Should().BeEquivalentTo(_scooter);
        }

        [TestMethod]
        public void Scooter_GetsANonExistantScooter_ThrowsScooterDoesNotExistsException()
        {
            // Act
            Action act = () => 
                Get.Scooter("2", _scooters);

            // Assert
            act.Should().Throw<ScooterDoesNotExistsException>()
                .WithMessage("Scooter with id 2 doesn't exist!");
        }

        [TestMethod]
        public void Scooter_GetsTheCorrectScooterFromMultipleScooters()
        {
            // Arrange
            _scooters.Add(new Scooter("2", 0.5m));
            _scooters.Add(new Scooter("253", 2m));

            // Act
            var result = Get.Scooter("253", _scooters);

            // Assert
            result.Should().BeEquivalentTo(new Scooter("253", 2m));
        }
    }
}