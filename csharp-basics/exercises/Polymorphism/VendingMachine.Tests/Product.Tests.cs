using FluentAssertions;

namespace VendingMachine.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void SetsAndGetsProduct()
        {
            // Arrange & Act
            var Product = new Product();
            var Money = new Money()
            {
                Euros = 1,
                Cents = 79
            };

            Product.Available = 20;
            Product.Price = Money;
            Product.Name = "Coca-Cola";

            // Assert
            Product.Available.Should().Be(20);
            Product.Price.Should().BeEquivalentTo(Money);
            Product.Name.Should().Be("Coca-Cola");
        }
    }
}