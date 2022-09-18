using FluentAssertions;

namespace VendingMachine.Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void SetsAndGetsMoney()
        {
            // Arrange & Act
            var Money = new Money();
            Money.Euros = 2;
            Money.Cents = 22;

            // Assert
            Money.Euros.Should().Be(2);
            Money.Cents.Should().Be(22);
        }
    }
}