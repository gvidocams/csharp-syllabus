using FluentAssertions;
using VendingMachine.Exceptions;

namespace VendingMachine.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        private Money _money;
        private List<Product> _productList;
        private IVendingMachine _vendingMachine;

        [TestInitialize]
        public void Setup()
        {
            _money = new Money()
            {
                Euros = 2,
                Cents = 50
            };
            _productList = new List<Product>();
            _vendingMachine = new VendingMachine("GetDrinksss", _money, _productList);
        }

        [TestMethod]
        public void VendingMachineSetCorrectly()
        {
            _vendingMachine.Manufacturer.Should().Be("GetDrinksss");
        }

        [TestMethod]
        public void HasProducts_NoProducts_ReturnsFalse()
        {
            _vendingMachine.HasProducts.Should().BeFalse();
        }

        [TestMethod]
        public void HasProducts_OneProduct_ReturnsTrue()
        {
            // Arrange
            _productList.Add(new Product());

            // Act & Assert
            _vendingMachine.HasProducts.Should().BeTrue();
        }

        [TestMethod]
        public void Amount_GetsMoney_ReturnsEmptyMoney()
        {
            _vendingMachine.Amount.Should().BeEquivalentTo(_money);
        }

        [TestMethod]
        public void Products_GetsProductList()
        {
            _vendingMachine.Products.Should().BeEquivalentTo(_productList);
        }

        [TestMethod]
        public void Products_SetsAndGetsProductList()
        {
            // Arrange
            var Product = new Product()
            {
                Available = 2,
                Name = "Fuel",
                Price = new Money()
                {
                    Euros = 1,
                    Cents = 50
                }
            };
            var products = new List<Product> { Product };

            _vendingMachine.Products = products.ToArray();

            _vendingMachine.Products.Should().BeEquivalentTo(products);
        }

        [TestMethod]
        public void InsertCoin_InsertsValidMoney_ReturnsMoney()
        {
            // Arrange
            var Money = new Money()
            {
                Euros = 2,
                Cents = 50
            };

            // Act & Assert
            _vendingMachine.InsertCoin(Money).Should().BeEquivalentTo(Money);
        }

        [TestMethod]
        public void InsertCoin_InsertsInvalidMoney_ThrowsInvalidMoneyException()
        {
            var Money = new Money()
            {
                Euros = 3,
                Cents = 70
            };

            Action act = () => _vendingMachine.InsertCoin(Money);

            act.Should().Throw<InvalidMoneyException>()
                .WithMessage("You can't put these coins in this vending machine!");
        }

        [TestMethod]
        public void InsertCoint_InsertsEmptyMoney_ReturnsEmptyMoney()
        {
            // Arrange
            var Money = new Money()
            {
                Euros = 0,
                Cents = 0
            };

            // Act & Assert
            _vendingMachine.InsertCoin(Money).Should().BeEquivalentTo(Money);
        }

        [TestMethod]
        public void ReturnMoney_ShouldReturnMoneyAndEmptyItself()
        {
            _vendingMachine.ReturnMoney().Should().BeEquivalentTo(_money);

            _vendingMachine.ReturnMoney().Should().BeEquivalentTo(new Money());
        }

        [TestMethod]
        public void AddProduct_AddsAValidProduct()
        {
            // Arrange
            string productName = "Twix";
            var price = new Money() { Euros = 1, Cents = 50 };
            int count = 5;

            // Act & Assert
            _vendingMachine.AddProduct(productName, price, count).Should().BeTrue();
            _productList.Should().ContainEquivalentOf(new Product() { Name = productName, Price = price, Available = count});
            
        }

        [TestMethod]
        public void AddProduct_AddsAProductWithEmptyPrice_ThrowsInvalidPriceException()
        {
            Action act = () => _vendingMachine.AddProduct("Twix", new Money(), 5);

            act.Should().Throw<InvalidPriceException>()
                .WithMessage("Nothing in life is for free!");
        }

        [TestMethod]
        public void UpdateProduct_UpdatesExistingProduct()
        {
            // Arrange
            var Product = new Product() { Name = "Twix", Available = 5, Price = new Money() { Euros = 0, Cents = 70} };
            var UpdatedProduct = new Product() { Name = "Twix", Available = 6, Price = new Money() { Euros = 0, Cents = 80 } };

            _productList.Add(Product);

            // Act & Assert
            _vendingMachine.UpdateProduct(0, "Twix", new Money() { Euros = 0, Cents = 80 }, 6).Should().BeTrue();
            _productList[0].Should().BeEquivalentTo(UpdatedProduct);
        }

        [TestMethod]
        public void UpdateProduct_UpdatesExistingProductWithPriceNull()
        {
            // Arrange
            var Product = new Product() { Name = "Twix", Available = 5, Price = new Money() { Euros = 0, Cents = 70 } };
            var UpdatedProduct = new Product() { Name = "Twix", Available = 2, Price = new Money() { Euros = 0, Cents = 70 } };

            _productList.Add(Product);

            // Act & Assert
            _vendingMachine.UpdateProduct(0, "Twix", null, 2).Should().BeTrue();
            _productList[0].Should().BeEquivalentTo(UpdatedProduct);
        }

        [TestMethod]
        public void UpdateProduct_InvalidProductNumber_ThrowsInvalidProductNumberException()
        {
            Action act = () => _vendingMachine.UpdateProduct(21, "Twix", new Money(), 6);

            act.Should().Throw<InvalidProductNumberException>()
                .WithMessage("Invalid product number!");
        }

        [TestMethod]
        public void UpdateProduct_InvalidPrice_ThrowsInvalidPriceException()
        {
            Action act = () => _vendingMachine.UpdateProduct(0, "Twix", new Money(), 6);

            act.Should().Throw<InvalidPriceException>()
                .WithMessage("Nothing in life is for free!");
        }
    }
}
