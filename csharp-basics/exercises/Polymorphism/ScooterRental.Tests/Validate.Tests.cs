using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Helper;
using ScooterRental.Exceptions;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ValidateTests
    {
        [TestMethod]
        public void ScooterId_PassValidId()
        {
            // Arrange
            string id = "1";

            // Act
            Action act = () => 
                Validate.ScooterId(id);

            // Assert
            act.Should().NotThrow();
        }

        [TestMethod]
        public void ScooterId_PassEmptyId_ThrowsInvalidIdException()
        {
            // Arrange
            string id = "";

            // Act
            Action act = () =>
                Validate.ScooterId(id);

            // Assert
            act.Should().Throw<InvalidIdException>()
                .WithMessage("Id cannot be null or empty!");
        }

        [TestMethod]
        public void ScooterId_PassNullId_ThrowsInvalidIdException()
        {
            // Arrange
            string id = null;

            // Act
            Action act = () =>
                Validate.ScooterId(id);

            // Assert
            act.Should().Throw<InvalidIdException>()
                .WithMessage("Id cannot be null or empty!");
        }
    }
}
