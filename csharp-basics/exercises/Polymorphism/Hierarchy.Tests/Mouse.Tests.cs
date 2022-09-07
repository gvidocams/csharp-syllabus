namespace Hierarchy.Tests
{
    [TestClass]
    public class MouseTests
    {
        private Mouse _mouse;

        [TestInitialize]
        public void Setup()
        {
            _mouse = new Mouse("Mouse", "Pele", 20, "House", 5);
        }

        [TestMethod]
        public void MakeSound_MakesMouseSpecificSound()
        {
            _mouse.MakeSound().Should().Be("Sqeak squek squeak...");
        }

        [TestMethod]
        public void Eat_EatsAVegetable()
        {
            // Arrange
            var Vegetable = new Vegetable(2);

            // Act & Assert
            _mouse.Eat(Vegetable).Should().Be("Chomp chomp");
        }

        [TestMethod]
        public void Eat_EatsMeat()
        {
            // Arrange
            var Meat = new Meat(2);

            // Act & Assert
            _mouse.Eat(Meat).Should().Be("Mouse doesn't eat that type of food");
        }

        [TestMethod]
        public void Display_ShouldDisplayMouseInfo()
        {
            // Act & Assert
            _mouse.Display().Should().Be("Animal type: Mouse | Name: Pele | Weight: 20 | Living region: House | Food eaten: 5");
        }
    }
}
