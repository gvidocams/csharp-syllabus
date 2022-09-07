using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;
// Mocking
using Moq;
using Moq.AutoMock;
// Mocking

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalCompanyTests
    {
        private IRentalCompany _rentalCompany;
        private IScooterService _scooterService;
        private List<RentalDetails> _rentalDetailList;
        private List<Scooter> _inventory;
        
        // Mocking

        private AutoMocker _mocker;
        private IRentalCompany _company;
        private Mock<IScooterService> _scooterServiceMock;
        private Scooter _defaultScooter;
        // Mocking

        [TestInitialize]
        public void Setup()
        {
            // Mocking
            _mocker = new AutoMocker();

            _scooterServiceMock = _mocker.GetMock<IScooterService>();
            _company = new RentalCompany("if", _scooterServiceMock.Object, new List<RentalDetails>());
            _defaultScooter = new Scooter("1", 0.2m);
            // Mocking

            _inventory = new List<Scooter> { new Scooter("1", 0.2m) };
            _scooterService = new ScooterService(_inventory);
            _rentalDetailList = new List<RentalDetails>();
            _rentalCompany = new RentalCompany("Bolt", _scooterService, _rentalDetailList);
        }

        [TestMethod]
        public void Name_GetsRentalCompanyName()
        {
            // Act
            var name = _rentalCompany.Name;

            //Assert
            name.Should().Be("Bolt");
        }

        // Mocking

        [TestMethod]
        public void StartRentTest()
        {
            _scooterServiceMock
                .Setup(s => s.GetScooterById("1"))
                .Returns(_defaultScooter);

            _company.StartRent("1");

            _defaultScooter.IsRented.Should().BeTrue();
        }

        // Mocking

        [TestMethod]
        public void StartRent_RentsAValidScooter_ScooterIsRented()
        {
            // Act
            _rentalCompany.StartRent("1");

            // Assert
            _inventory[0].IsRented.Should().BeTrue();
        }

        [TestMethod]
        public void StartRent_RentsAnAlreadyRentedScooter_ThrowsScooterStillRentedException()
        {
            // Arrange
            _inventory[0].IsRented = true;

            // Act
            Action act = () => 
                _rentalCompany.StartRent("1");

            // Assert
            act.Should().Throw<ScooterIsStillRentedException>()
                .WithMessage("Can't remove a scooter with id 1 because it's still being rented!");
        }

        [TestMethod]
        public void StartRent_RentsAScooter_RentalPeriodGetsNewRent()
        {
            // Act
            _rentalCompany.StartRent("1");

            // Assert
            _rentalDetailList.Count.Should().Be(1);
        }

        [TestMethod]
        public void EndRent_EndsRentForValidScooter_ScooterIsNotRented()
        {
            // Arrange
            var scooter = _scooterService.GetScooterById("1");
            var scooterReport = new RentalDetails("1", DateTime.Now, 0.2m);

            _rentalDetailList.Add(scooterReport);

            scooter.IsRented = true;

            // Act
            _rentalCompany.EndRent("1");

            // Assert
            scooter.IsRented.Should().BeFalse();
            scooterReport.EndTime.Should().HaveValue();
        }

        [TestMethod]
        public void EndRent_EndRentToScooterThatHasntBeenRented_ThrowsScooterIsntRentedToEndRentException()
        {
            // Act
            Action act = () => _rentalCompany.EndRent("1");

            // Assert
            act.Should().Throw<ScooterIsntRentedToEndRentException>()
                .WithMessage("Can't end rent to this scooter with id 1 because it hasn't been rented in the first place!");
        }

        [TestMethod]
        public void EndRent_ValidScooterRentalTime2Minutes_04RentalPrice()
        {
            // Arrange
            _inventory[0].IsRented = true;
            _rentalDetailList.Add(new RentalDetails("1", DateTime.Now.AddMinutes(-2), 0.2m));

            // Act
            var result = _rentalCompany.EndRent("1");

            // Assert
            result.Should().Be(0.4m);
        }

        [TestMethod]
        public void EndRent_CalculatesPriceForTwoDays_ShouldBe40()
        {
            // Arrange
            _inventory[0].IsRented = true;
            _rentalDetailList.Add(new RentalDetails("1", DateTime.Now.AddMinutes(-2), 0.2m));

            // Act
            var result = _rentalCompany.EndRent("1");

            // Assert
            result.Should().Be(0.4m);
        }

        [TestMethod]
        public void EndRent_EndsTheCorrectInstanceOfRent()
        {
            // Arrange
            _inventory[0].IsRented = true;
            var report = new RentalDetails("1", DateTime.Now.AddMinutes(-2), 0.2m);
            _rentalDetailList.Add(report);

            _rentalCompany.EndRent("1");

            _inventory[0].IsRented = true;
            _rentalDetailList.Add(new RentalDetails("1", DateTime.Now.AddMinutes(-4), 0.2m));

            // Act
            var result = _rentalCompany.EndRent("1");
            var isRented = _inventory[0].IsRented;

            // Assert
            result.Should().Be(0.8m);
            isRented.Should().BeFalse();
        }

        [TestMethod]
        public void EndRent_EndsTheCorrectInstanceOfRentWithMultipleScooters()
        {
            // Arrange
            _inventory.Add(new Scooter("2", 0.2m));

            _inventory[0].IsRented = true;
            _rentalDetailList.Add(new RentalDetails("1", DateTime.Now.AddMinutes(-2), 0.2m));

            _rentalCompany.EndRent("1");

            _inventory[0].IsRented = true;
            _rentalDetailList.Add(new RentalDetails("1", DateTime.Now.AddMinutes(-4), 0.2m));

            // Act
            var result = _rentalCompany.EndRent("1");
            
            // Assert
            result.Should().Be(0.8m);
        }

        [TestMethod]
        public void CalculateIncome_ShouldCalculateIncomeFromOneScooterRent()
        {
            // Arrange
            var rent = new RentalDetails("1", DateTime.Now.AddMinutes(-2), 0.2m);
            rent.EndTime = DateTime.Now;

            _rentalDetailList.Add(rent);

            // Act
            var result = _rentalCompany.CalculateIncome(null, false);

            // Assert
            result.Should().Be(0.4m);
        }

        [TestMethod]
        public void CalculateIncome_ShouldCalculateIncomeFromTwoEndedScooterReports()
        {
            // Arrange
            var report = new RentalDetails("1", DateTime.Now.AddMinutes(-4), 0.2m);

            report.EndTime = DateTime.Now.AddMinutes(-2);

            _rentalDetailList.Add(report);
            _rentalDetailList.Add(report);

            // Act
            var result = _rentalCompany.CalculateIncome(null, false);

            // Assert
            result.Should().Be(0.8m);
        }
        
        [TestMethod]
        public void CalculateIncome_CalculatesIncomeOnlyFromYear2022()
        {
            // Arrange
            var report1 = new RentalDetails("1", new DateTime(2022, 1, 1, 0, 0, 0), 0.2m);
            report1.EndTime = new DateTime(2022, 1, 1, 0, 2, 0);

            _rentalDetailList.Add(report1);

            var report2 = new RentalDetails("1", new DateTime(2021, 1, 1, 0, 0, 0), 0.2m);
            report2.EndTime = new DateTime(2021, 1, 2, 0, 2, 0);

            _rentalDetailList.Add(report2);

            var report3 = new RentalDetails("1", new DateTime(2021, 1, 1, 0, 0, 0), 0.2m);

            _rentalDetailList.Add(report3);

            // Act
            var result = _rentalCompany.CalculateIncome(2022, false);

            // Assert
            result.Should().Be(0.4m);
        }

        [TestMethod]
        public void CalculateIncome_IncludeAllReportsAndNotCompletedRentals()
        {
            // Arrange
            var report1 = new RentalDetails("1", DateTime.Now.AddMinutes(-2), 0.2m);
            _rentalDetailList.Add(report1);

            var report2 = new RentalDetails("1", new DateTime(2021, 1, 1, 0, 0, 0), 0.2m);
            report2.EndTime = new DateTime(2021, 1, 1, 0, 2, 0);
            _rentalDetailList.Add(report2);

            // Act
            var result = _rentalCompany.CalculateIncome(null, true);

            // Assert
            result.Should().Be(0.8m);
        }

        [TestMethod]
        public void CalculateIncome_IncludeAllReportsAndNotCompletedRentalsYear2021()
        {
            // Arrange
            var report1 = new RentalDetails("1", new DateTime(2021, 1, 1, 0, 0, 0), 0.2m);
            _rentalDetailList.Add(report1);

            var report2 = new RentalDetails("1", new DateTime(2021, 1, 1, 0, 0, 0), 0.2m);
            report2.EndTime = new DateTime(2021, 1, 1, 0, 2, 0);
            _rentalDetailList.Add(report2);

            // Act
            var result = _rentalCompany.CalculateIncome(2021, true);

            // Assert
            result.Should().Be(0.4m);
        }
    }
}
