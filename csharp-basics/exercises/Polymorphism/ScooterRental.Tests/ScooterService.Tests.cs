using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ScooterServiceTests
    {
        private IScooterService _scooterService;
        private List<IScooter> _inventory;

        [TestInitialize]
        public void Setup()
        {
            _inventory = new List<IScooter> { new Scooter("1", 0.2m) };
            _scooterService = new ScooterService(_inventory);
        }

        [TestMethod]
        public void AddScooter_AddValidScooter_ScooterAdded()
        {
            // Act
            var result = _inventory.Count;

            // Assert
            result.Should().Be(1);
        }

        [TestMethod]
        public void AddScooter_AddSameScooterTwice_ThrowsDuplicateScooterException()
        {
            // Act
            Action act = () =>
                _scooterService.AddScooter("1", 0.2m);

            // Assert
            act.Should().Throw<DuplicateScooterException>()
                .WithMessage("Scooter with id 1 already exists!");
        }

        [TestMethod]
        public void AddScooter_AddScooterWithWithPriceZeroOrLess_ThrowsInvalidPriceException()
        {
            // Act
            Action act = () =>
                _scooterService.AddScooter("1", -0.2m);

            // Assert
            act.Should().Throw<InvalidPriceException>()
                .WithMessage("Given price -0,2 not valid!");
        }

        [TestMethod]
        public void AddScooter_AddScooterNullOrEmptyId_ThrowsInvalidIdException()
        {
            // Act
            Action act = () =>
                _scooterService.AddScooter("", 0.2m);

            // Assert
            act.Should().Throw<InvalidIdException>()
                .WithMessage("Id cannot be null or empty!");
        }

        [TestMethod]
        public void RemoveScooter_ScooterExists_ScooterIsRemoved()
        {
            // Act
            _scooterService.RemoveScooter("1");

            // Assert
            _inventory.Count.Should().Be(0);
        }

        [TestMethod]
        public void RemoveScooter_ScooterDoesntExist_ThrowsScooterDoesNotExistsException()
        {
            // Act
            Action act = () =>
                _scooterService.RemoveScooter("2");

            // Assert
            act.Should().Throw<ScooterDoesNotExistsException>()
                .WithMessage("Scooter with id 2 doesn't exist!");
        }

        [TestMethod]
        public void RemoveScooter_NullOrEmptyId_ThrowsInvalidIdException()
        {
            // Act
            Action act = () =>
                _scooterService.RemoveScooter("");

            // Assert
            act.Should().Throw<InvalidIdException>()
                .WithMessage("Id cannot be null or empty!");
        }

        [TestMethod]
        public void RemoveScooter_IsRented_ThrowsScooterIsRentedException()
        {
            // Arrange
            _inventory[0].IsRented = true;

            // Act
            Action act = () =>
                _scooterService.RemoveScooter("1");

            // Assert
            act.Should().Throw<ScooterIsStillRentedException>()
                .WithMessage("Can't remove a scooter with id 1 because it's still being rented!");
        }

        [TestMethod]
        public void GetScooters_AddScooterAndGetsScooterList()
        {
            // Act
            var result = _scooterService.GetScooters();

            // Assert
            result.Count.Should().Be(1);
        }

        [TestMethod]
        public void GetScooters_AddScooterAndGetsScooterList_GetsTwoScooters()
        {
            // Arrange
            _scooterService.AddScooter("2", 0.2m);

            // Act
            var result = _scooterService.GetScooters();

            // Assert
            result.Count.Should().Be(2);
        }

        [TestMethod]
        public void GetScooters_AddScootersAndSetsOneScooterRented_GetsOnlyNotRentedScooters()
        {
            // Arrange
            _scooterService.AddScooter("2", 0.2m);
            _inventory[1].IsRented = true;

            // Act
            var result = _scooterService.GetScooters();

            // Assert
            result.Should().OnlyContain(scooter => !scooter.IsRented);
            result.Count.Should().Be(1);
        }

        [TestMethod]
        public void GetScooters_GetListOfScooters_ChangingListShouldNotChangeOriginalList()
        {
            // Arrange
            _scooterService.AddScooter("2", 0.2m);

            // Act
            var result = _scooterService.GetScooters();
            result.Add(new Scooter("3", 0.2m));

            // Assert
            _scooterService.GetScooters().Count.Should().Be(2);
        }

        [TestMethod]
        public void GetScooterById_ScooterExists_GetScooter()
        {
            // Act
            var result = _scooterService.GetScooterById("1");

            // Assert
            result.Id.Should().Be("1");
            result.PricePerMinute.Should().Be(0.2m);
        }

        [TestMethod]
        public void GetScooterById_NullOrEmptyId_ThrowsInvalidIdException()
        {
            // Act
            Action act = () =>
                _scooterService.GetScooterById("");

            // Assert
            act.Should().Throw<InvalidIdException>()
                .WithMessage("Id cannot be null or empty!");
        }

        [TestMethod]
        public void GetScooterById_ScooterDoesntExist_ThrowsScooterDoesNotExistsException()
        {
            // Act
            Action act = () =>
                _scooterService.GetScooterById("2");

            // Assert
            act.Should().Throw<ScooterDoesNotExistsException>()
                .WithMessage("Scooter with id 2 doesn't exist!");
        }
    }
}
