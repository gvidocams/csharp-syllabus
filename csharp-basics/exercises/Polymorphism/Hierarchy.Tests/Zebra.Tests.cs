namespace Hierarchy.Tests
{
    [TestClass]
    public class ZebraTests
    {
        private Zebra _zebra;

        [TestInitialize]
        public void Setup()
        {
            _zebra = new Zebra("Zebra", "Marty", 100, "Madagascar", 20);
        }

        [TestMethod]
        public void MakeSound_MakeSpecificZebraSound()
        {
            _zebra.MakeSound().Should().Be("Neigh");
        }

        [TestMethod]
        public void Eat_EatsVegetable()
        {
            // Arrange
            var Vegetable = new Vegetable(2);

            // Act & Assert
            _zebra.Eat(Vegetable).Should().Be("Chomp chomp");
        }

        [TestMethod]
        public void Eat_EatsMeat()
        {
            // Arrange
            var Meat = new Meat(2);

            // Act & Assert
            _zebra.Eat(Meat).Should().Be("Zebra doesn't eat that type of food");
        }

        [TestMethod]
        public void Display_ShouldDisplayZebraInfo()
        {
            _zebra.Display().Should().Be("Animal type: Zebra | Name: Marty | Weight: 100 | Living region: Madagascar | Food eaten: 20");
        }
    }
}